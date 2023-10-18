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
            SuspendLayout();
            // 
            // printBallButton
            // 
            printBallButton.Location = new Point(640, 58);
            printBallButton.Name = "printBallButton";
            printBallButton.Size = new Size(94, 29);
            printBallButton.TabIndex = 0;
            printBallButton.Text = " Рисовать мячик";
            printBallButton.UseVisualStyleBackColor = true;
            printBallButton.Click += printBallButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printBallButton);
            Name = "MainForm";
            Text = "Мячики";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button printBallButton;
    }
}