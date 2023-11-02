namespace _2048RealiseWindowsForm
{
    partial class MainForm2
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
            startGameButton = new Button();
            restartButton = new Button();
            exitButton = new Button();
            stopBallButton = new Button();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(668, 12);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(94, 29);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Запуск";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(12, 12);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(123, 29);
            restartButton.TabIndex = 1;
            restartButton.Text = "Рестарт игры";
            restartButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 409);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // stopBallButton
            // 
            stopBallButton.Location = new Point(628, 409);
            stopBallButton.Name = "stopBallButton";
            stopBallButton.Size = new Size(144, 29);
            stopBallButton.TabIndex = 3;
            stopBallButton.Text = "Отсановить мячи";
            stopBallButton.UseVisualStyleBackColor = true;
            // 
            // MainForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopBallButton);
            Controls.Add(exitButton);
            Controls.Add(restartButton);
            Controls.Add(startGameButton);
            Name = "MainForm2";
            Text = "Поймай мячик";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startGameButton;
        private Button restartButton;
        private Button exitButton;
        private Button stopBallButton;
    }
}