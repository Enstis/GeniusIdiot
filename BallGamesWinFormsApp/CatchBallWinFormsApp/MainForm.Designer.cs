namespace CatchBallWinFormsApp
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
            components = new System.ComponentModel.Container();
            startButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            StopButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(694, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "Запуск";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(691, 62);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(94, 29);
            StopButton.TabIndex = 1;
            StopButton.Text = "Стоп";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(694, 115);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 2;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(StopButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "Поймай мячик";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private System.Windows.Forms.Timer timer;
        private Button StopButton;
        private Button clearButton;
    }
}