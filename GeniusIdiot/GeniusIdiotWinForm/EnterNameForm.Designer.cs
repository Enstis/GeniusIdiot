﻿namespace GeniusIdiotWinForm
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
            applyEnteringNameButton = new Button();
            label1 = new Label();
            enterNameTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // applyEnteringNameButton
            // 
            applyEnteringNameButton.Location = new Point(126, 227);
            applyEnteringNameButton.Name = "applyEnteringNameButton";
            applyEnteringNameButton.Size = new Size(141, 57);
            applyEnteringNameButton.TabIndex = 0;
            applyEnteringNameButton.Text = "Подтвердить";
            applyEnteringNameButton.UseVisualStyleBackColor = true;
            applyEnteringNameButton.Click += applyEnteringNameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 55);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите Ваше имя:";
            // 
            // enterNameTextBox
            // 
            enterNameTextBox.AcceptsTab = true;
            enterNameTextBox.Location = new Point(126, 142);
            enterNameTextBox.Name = "enterNameTextBox";
            enterNameTextBox.Size = new Size(141, 27);
            enterNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 310);
            label2.Name = "label2";
            label2.Size = new Size(382, 40);
            label2.TabIndex = 3;
            label2.Text = "Как только вы подтвердите имя, сразу начнется игра.\r\nУ вас есть 10 секунд, чтобы ответить на вопрос.";
            // 
            // EnterNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 382);
            Controls.Add(label2);
            Controls.Add(enterNameTextBox);
            Controls.Add(label1);
            Controls.Add(applyEnteringNameButton);
            Name = "EnterNameForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button applyEnteringNameButton;
        private Label label1;
        public TextBox enterNameTextBox;
        private Label label2;
    }
}