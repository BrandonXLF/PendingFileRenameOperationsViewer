using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Windows.Forms;

namespace PendingFileRenameOperationsViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Icon = AppResources.AppIcon;

            OperationGrid.AutoGenerateColumns = false;
            OperationGrid.DataSource = new BindingSource
            {
                DataSource = new OperationsDataTable()
            };
        }

        private void OperationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) {
                OperationGrid.Rows.RemoveAt(e.RowIndex);
                return;
            }

            var remainderBy3 = e.ColumnIndex % 3;

            if (remainderBy3 == 0) return;

            var currentColIndex = e.ColumnIndex - remainderBy3;
            var current = (string)OperationGrid[currentColIndex, e.RowIndex].Value;

            var dialog = new CommonOpenFileDialog
            {
                EnsureFileExists = false,
                EnsurePathExists = false,
                IsFolderPicker = remainderBy3 == 2,
                InitialDirectory = Path.GetDirectoryName(current)
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                OperationGrid[currentColIndex, e.RowIndex].Value = dialog.FileName;
                OperationGrid.NotifyCurrentCellDirty(true);
            }
        }
    }
}
