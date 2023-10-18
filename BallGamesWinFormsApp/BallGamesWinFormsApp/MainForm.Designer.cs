namespace BallGamesWinFormsApp
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
            printBallButton = new Button();
            printRandomButton = new Button();
            SuspendLayout();
            // 
            // printBallButton
            // 
            printBallButton.Location = new Point(623, 12);
            printBallButton.Name = "printBallButton";
            printBallButton.Size = new Size(165, 29);
            printBallButton.TabIndex = 0;
            printBallButton.Text = " Рисовать мячик";
            printBallButton.UseVisualStyleBackColor = true;
            printBallButton.Click += printBallButton_Click;
            // 
            // printRandomButton
            // 
            printRandomButton.Location = new Point(406, 12);
            printRandomButton.Name = "printRandomButton";
            printRandomButton.Size = new Size(211, 29);
            printRandomButton.TabIndex = 1;
            printRandomButton.Text = "Рисовать случайный мячик";
            printRandomButton.UseVisualStyleBackColor = true;
            printRandomButton.Click += printRandomButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printRandomButton);
            Controls.Add(printBallButton);
            Name = "MainForm";
            Text = "Мячики";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button printBallButton;
        private Button printRandomButton;
    }
}