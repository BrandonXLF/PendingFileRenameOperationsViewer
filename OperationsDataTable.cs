using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;

namespace PendingFileRenameOperationsViewer
{
    internal class OperationsDataTable : DataTable
    {
        private static readonly string RegistryKey = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager";
        private static readonly string RegistryValue = "PendingFileRenameOperations";

        private bool AddingBlank = false;

        public OperationsDataTable()
        {
            Load();

            ColumnChanged += (sender, e) => Save();
            RowDeleted += (sender, e) => Save();
        }

        private void AddBlank()
        {
            AddingBlank = true;

            var row = NewRow();
            row["source"] = row["dest"] = string.Empty;
            Rows.Add(row);

            AddingBlank = false;
            Save();
        }

        private void Load()
        {
            string[] operations = (string[])Registry.GetValue(RegistryKey, RegistryValue, Array.Empty<string>());

            Clear();

            Columns.Add("source", typeof(string));
            Columns.Add("dest", typeof(string));

            for (int i = 0; i < operations.Length; i += 2)
            {
                var source = operations[i];
                var dest = i + 1 == operations.Length ? string.Empty : operations[i + 1];

                var row = NewRow();
                row["source"] = source.Length > 0 ? source[4..] : source;
                row["dest"] = dest.Length > 0 ? dest[5..] : dest;
                Rows.Add(row);
            }

            AddBlank();
        }

        private void Save()
        {
            if (AddingBlank) return;

            var lastIsBlank = false;

            if (Rows.Count > 0)
            {
                var lastRow = Rows[^1];
                lastIsBlank = (string)lastRow["source"] == "" && (string)lastRow["dest"] == "";
            }

            var operations = new List<string>();

            foreach (DataRow row in Rows)
            {
                var source = (string)row["source"];
                var dest = (string)row["dest"];

                operations.Add(source.Length > 0 ? "\\??\\" + source : source);
                operations.Add(dest.Length > 0 ? "!\\??\\" + dest : dest);
            }

            if (lastIsBlank)
            {
                operations.RemoveAt(operations.Count - 1);
                operations.RemoveAt(operations.Count - 1);
            }

            Registry.SetValue(RegistryKey, RegistryValue, operations.ToArray());

            if (!lastIsBlank)
            {
                AddBlank();
            }
        }
    }
}
