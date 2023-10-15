namespace _2048WinFormsApp
{
    partial class TableResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResultDataGridView = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            scoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultDataGridView
            // 
            ResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, scoreColumn });
            ResultDataGridView.Location = new Point(12, 24);
            ResultDataGridView.Name = "ResultDataGridView";
            ResultDataGridView.RowHeadersWidth = 51;
            ResultDataGridView.RowTemplate.Height = 29;
            ResultDataGridView.Size = new Size(554, 387);
            ResultDataGridView.TabIndex = 0;
            
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Имя";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 250;
            // 
            // scoreColumn
            // 
            scoreColumn.HeaderText = "Результат";
            scoreColumn.MinimumWidth = 6;
            scoreColumn.Name = "scoreColumn";
            scoreColumn.Width = 250;
            // 
            // TableResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 416);
            Controls.Add(ResultDataGridView);
            Name = "TableResultForm";
            Text = "Таблица результатов";
            Load += TableResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ResultDataGridView;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn scoreColumn;
    }
}