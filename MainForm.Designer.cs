
namespace PendingFileRenameOperationsViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OperationGrid = new System.Windows.Forms.DataGridView();
            SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SourceFileSelectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            SourceFolderSelectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            DestColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DestFileSelectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            DestFolderSelectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            RemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OperationGrid).BeginInit();
            SuspendLayout();
            // 
            // OperationGrid
            // 
            OperationGrid.AllowUserToAddRows = false;
            OperationGrid.AllowUserToResizeRows = false;
            OperationGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            OperationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            OperationGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            OperationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            OperationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OperationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SourceColumn, SourceFileSelectColumn, SourceFolderSelectColumn, DestColumn, DestFileSelectColumn, DestFolderSelectColumn, RemoveColumn });
            OperationGrid.Location = new System.Drawing.Point(21, 24);
            OperationGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            OperationGrid.Name = "OperationGrid";
            OperationGrid.RowHeadersVisible = false;
            OperationGrid.RowHeadersWidth = 40;
            OperationGrid.RowTemplate.Height = 35;
            OperationGrid.Size = new System.Drawing.Size(1330, 688);
            OperationGrid.TabIndex = 4;
            OperationGrid.CellClick += OperationGrid_CellClick;
            // 
            // SourceColumn
            // 
            SourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            SourceColumn.DataPropertyName = "source";
            SourceColumn.HeaderText = "Source";
            SourceColumn.MinimumWidth = 150;
            SourceColumn.Name = "SourceColumn";
            SourceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SourceFileSelectColumn
            // 
            SourceFileSelectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            SourceFileSelectColumn.HeaderText = "";
            SourceFileSelectColumn.MinimumWidth = 40;
            SourceFileSelectColumn.Name = "SourceFileSelectColumn";
            SourceFileSelectColumn.ReadOnly = true;
            SourceFileSelectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            SourceFileSelectColumn.Text = "🗎";
            SourceFileSelectColumn.UseColumnTextForButtonValue = true;
            SourceFileSelectColumn.Width = 40;
            // 
            // SourceFolderSelectColumn
            // 
            SourceFolderSelectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            SourceFolderSelectColumn.HeaderText = "";
            SourceFolderSelectColumn.MinimumWidth = 40;
            SourceFolderSelectColumn.Name = "SourceFolderSelectColumn";
            SourceFolderSelectColumn.ReadOnly = true;
            SourceFolderSelectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            SourceFolderSelectColumn.Text = "🗁";
            SourceFolderSelectColumn.UseColumnTextForButtonValue = true;
            SourceFolderSelectColumn.Width = 40;
            // 
            // DestColumn
            // 
            DestColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DestColumn.DataPropertyName = "dest";
            DestColumn.HeaderText = "Destination";
            DestColumn.MinimumWidth = 150;
            DestColumn.Name = "DestColumn";
            DestColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DestFileSelectColumn
            // 
            DestFileSelectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DestFileSelectColumn.HeaderText = "";
            DestFileSelectColumn.MinimumWidth = 40;
            DestFileSelectColumn.Name = "DestFileSelectColumn";
            DestFileSelectColumn.ReadOnly = true;
            DestFileSelectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DestFileSelectColumn.Text = "🗎";
            DestFileSelectColumn.UseColumnTextForButtonValue = true;
            DestFileSelectColumn.Width = 40;
            // 
            // DestFolderSelectColumn
            // 
            DestFolderSelectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DestFolderSelectColumn.HeaderText = "";
            DestFolderSelectColumn.MinimumWidth = 40;
            DestFolderSelectColumn.Name = "DestFolderSelectColumn";
            DestFolderSelectColumn.ReadOnly = true;
            DestFolderSelectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DestFolderSelectColumn.Text = "🗁";
            DestFolderSelectColumn.UseColumnTextForButtonValue = true;
            DestFolderSelectColumn.Width = 40;
            // 
            // RemoveColumn
            // 
            RemoveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            RemoveColumn.HeaderText = "";
            RemoveColumn.MinimumWidth = 40;
            RemoveColumn.Name = "RemoveColumn";
            RemoveColumn.ReadOnly = true;
            RemoveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            RemoveColumn.Text = "🗑";
            RemoveColumn.UseColumnTextForButtonValue = true;
            RemoveColumn.Width = 40;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1371, 727);
            Controls.Add(OperationGrid);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Pending File Rename Operations Viewer";
            ((System.ComponentModel.ISupportInitialize)OperationGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView OperationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SourceFileSelectColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SourceFolderSelectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DestFileSelectColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DestFolderSelectColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveColumn;
    }
}

