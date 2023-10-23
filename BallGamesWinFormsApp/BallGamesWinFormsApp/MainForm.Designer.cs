namespace BallGamesWinFormsApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            button3 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(565, 12);
            button3.Name = "button3";
            button3.Size = new Size(223, 29);
            button3.TabIndex = 2;
            button3.Text = "Остановить все шарики";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer
            // 
            timer.Interval = 10;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(223, 29);
            button4.TabIndex = 3;
            button4.Text = "Запуск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Рестарт";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(623, 409);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 5;
            button2.Text = "Закончить игру";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private System.Windows.Forms.Timer timer;
        private Button button4;
        private Button button1;
        private Button button2;
    }
}