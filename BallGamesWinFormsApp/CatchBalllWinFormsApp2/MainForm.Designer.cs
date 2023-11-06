namespace CatchBalllWinFormsApp2
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
            startButton = new Button();
            clearButton = new Button();
            countBallsLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(694, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(694, 47);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // countBallsLabel
            // 
            countBallsLabel.AutoSize = true;
            countBallsLabel.Location = new Point(567, 9);
            countBallsLabel.Name = "countBallsLabel";
            countBallsLabel.Size = new Size(17, 20);
            countBallsLabel.TabIndex = 2;
            countBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countBallsLabel);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "Поймай мячик мышкой";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button clearButton;
        private Label countBallsLabel;
    }
}