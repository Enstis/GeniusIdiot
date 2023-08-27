namespace GeniusIdiotWinForm
{
    partial class QuestionDelForm
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
            resultsForRemoveQuestiondataGridView = new DataGridView();
            QuestionColumn = new DataGridViewTextBoxColumn();
            removeQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)resultsForRemoveQuestiondataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsForRemoveQuestiondataGridView
            // 
            resultsForRemoveQuestiondataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsForRemoveQuestiondataGridView.Columns.AddRange(new DataGridViewColumn[] { QuestionColumn });
            resultsForRemoveQuestiondataGridView.Location = new Point(0, 2);
            resultsForRemoveQuestiondataGridView.Name = "resultsForRemoveQuestiondataGridView";
            resultsForRemoveQuestiondataGridView.RowHeadersWidth = 51;
            resultsForRemoveQuestiondataGridView.RowTemplate.Height = 29;
            resultsForRemoveQuestiondataGridView.Size = new Size(700, 365);
            resultsForRemoveQuestiondataGridView.TabIndex = 0;
            // 
            // QuestionColumn
            // 
            QuestionColumn.HeaderText = "Вопросы";
            QuestionColumn.MinimumWidth = 6;
            QuestionColumn.Name = "QuestionColumn";
            QuestionColumn.Width = 1000;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Location = new Point(287, 392);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(146, 61);
            removeQuestionButton.TabIndex = 1;
            removeQuestionButton.Text = "Удалить";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // QuestionDelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 478);
            Controls.Add(removeQuestionButton);
            Controls.Add(resultsForRemoveQuestiondataGridView);
            Name = "QuestionDelForm";
            Text = "Выберите вопрос:";
            Load += QuestionDelForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsForRemoveQuestiondataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsForRemoveQuestiondataGridView;
        private Button removeQuestionButton;
        private DataGridViewTextBoxColumn QuestionColumn;
    }
}