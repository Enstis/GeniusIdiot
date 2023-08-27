namespace GeniusIdiotWinForm
{
    partial class QuestionAddForm
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
            OkButton = new Button();
            newQuestionTextBox = new TextBox();
            newAnswerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(320, 299);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "ОК";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // newQuestionTextBox
            // 
            newQuestionTextBox.Location = new Point(92, 187);
            newQuestionTextBox.Name = "newQuestionTextBox";
            newQuestionTextBox.Size = new Size(213, 27);
            newQuestionTextBox.TabIndex = 1;
            // 
            // newAnswerTextBox
            // 
            newAnswerTextBox.Location = new Point(433, 187);
            newAnswerTextBox.Name = "newAnswerTextBox";
            newAnswerTextBox.Size = new Size(182, 27);
            newAnswerTextBox.TabIndex = 2;
            newAnswerTextBox.KeyPress += newAnswerTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 89);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите вопрос";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 89);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите ответ на вопрос";
            // 
            // QuestionAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 420);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newAnswerTextBox);
            Controls.Add(newQuestionTextBox);
            Controls.Add(OkButton);
            Name = "QuestionAddForm";
            Text = "Добавить новый вопрос";
            Load += QuestionAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private TextBox newQuestionTextBox;
        private TextBox newAnswerTextBox;
        private Label label1;
        private Label label2;
    }
}