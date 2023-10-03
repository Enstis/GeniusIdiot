namespace _2048WinFormsApp
{
    partial class EnterNameForm
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
            enterNameTextBox = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // enterNameTextBox
            // 
            enterNameTextBox.Location = new Point(141, 158);
            enterNameTextBox.Name = "enterNameTextBox";
            enterNameTextBox.Size = new Size(141, 27);
            enterNameTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(141, 245);
            okButton.Name = "okButton";
            okButton.Size = new Size(141, 46);
            okButton.TabIndex = 1;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // EnterNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 378);
            Controls.Add(okButton);
            Controls.Add(enterNameTextBox);
            Name = "EnterNameForm";
            Text = "Введите имя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox enterNameTextBox;
        private Button okButton;
    }
}