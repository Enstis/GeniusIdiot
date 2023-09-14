using System;
using System.Windows.Forms;

namespace GeniusIdiotWinForm
{
    partial class mainForm
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
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            показатьТаблицуРезультатовToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            вопросыToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            countDownLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(12, 240);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(140, 69);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(12, 89);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(90, 20);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(12, 139);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(108, 20);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(12, 184);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(140, 27);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, вопросыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(542, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьТаблицуРезультатовToolStripMenuItem, рестартToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // показатьТаблицуРезультатовToolStripMenuItem
            // 
            показатьТаблицуРезультатовToolStripMenuItem.Name = "показатьТаблицуРезультатовToolStripMenuItem";
            показатьТаблицуРезультатовToolStripMenuItem.Size = new Size(304, 26);
            показатьТаблицуРезультатовToolStripMenuItem.Text = "Показать таблицу результатов";
            показатьТаблицуРезультатовToolStripMenuItem.Click += показатьТаблицуРезультатовToolStripMenuItem_Click;
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(304, 26);
            рестартToolStripMenuItem.Text = "Рестарт";
            рестартToolStripMenuItem.Click += рестартToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(304, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // вопросыToolStripMenuItem
            // 
            вопросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem, добавитьToolStripMenuItem });
            вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            вопросыToolStripMenuItem.Size = new Size(86, 24);
            вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(159, 26);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(159, 26);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 89);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 5;
            label1.Text = "Оставшееся время";
            // 
            // countDownLabel
            // 
            countDownLabel.AutoSize = true;
            countDownLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            countDownLabel.Location = new Point(272, 170);
            countDownLabel.Name = "countDownLabel";
            countDownLabel.Size = new Size(255, 41);
            countDownLabel.TabIndex = 6;
            countDownLabel.Text = "Обратный отсчет";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 438);
            Controls.Add(countDownLabel);
            Controls.Add(label1);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "Гений Идиот";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem показатьТаблицуРезультатовToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem вопросыToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private Label label1;
        private Label countDownLabel;
        public System.Windows.Forms.Timer timer1;
    }
}