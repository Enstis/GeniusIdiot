namespace _2048WinFormsApp
{
    partial class EnterForm
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
            mapSizeComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // enterNameTextBox
            // 
            enterNameTextBox.Location = new Point(141, 75);
            enterNameTextBox.Name = "enterNameTextBox";
            enterNameTextBox.Size = new Size(141, 27);
            enterNameTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(141, 303);
            okButton.Name = "okButton";
            okButton.Size = new Size(141, 46);
            okButton.TabIndex = 1;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // mapSizeComboBox
            // 
            mapSizeComboBox.FormattingEnabled = true;
            mapSizeComboBox.Items.AddRange(new object[] { "4х4", "5х5", "6х6" });
            mapSizeComboBox.Location = new Point(141, 218);
            mapSizeComboBox.Name = "mapSizeComboBox";
            mapSizeComboBox.Size = new Size(141, 28);
            mapSizeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 172);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 3;
            label1.Text = "Выберете размер поля";
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 378);
            Controls.Add(label1);
            Controls.Add(mapSizeComboBox);
            Controls.Add(okButton);
            Controls.Add(enterNameTextBox);
            Name = "EnterForm";
            Text = "Введите имя";
            Load += EnterNameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox enterNameTextBox;
        public Button okButton;
        public ComboBox mapSizeComboBox;
        private Label label1;
    }
}