namespace BilliardBallWindowsFormsApp
{
    partial class BilliardForm
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
            this.leftSideLabel = new System.Windows.Forms.Label();
            this.rightSideLabel = new System.Windows.Forms.Label();
            this.topSideLabel = new System.Windows.Forms.Label();
            this.downSideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftSideLabel
            // 
            this.leftSideLabel.AutoSize = true;
            this.leftSideLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSideLabel.Location = new System.Drawing.Point(12, 183);
            this.leftSideLabel.Name = "leftSideLabel";
            this.leftSideLabel.Size = new System.Drawing.Size(20, 22);
            this.leftSideLabel.TabIndex = 0;
            this.leftSideLabel.Text = "0";
            // 
            // rightSideLabel
            // 
            this.rightSideLabel.AutoSize = true;
            this.rightSideLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightSideLabel.Location = new System.Drawing.Point(768, 195);
            this.rightSideLabel.Name = "rightSideLabel";
            this.rightSideLabel.Size = new System.Drawing.Size(20, 22);
            this.rightSideLabel.TabIndex = 1;
            this.rightSideLabel.Text = "0";
            // 
            // topSideLabel
            // 
            this.topSideLabel.AutoSize = true;
            this.topSideLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSideLabel.Location = new System.Drawing.Point(370, 9);
            this.topSideLabel.Name = "topSideLabel";
            this.topSideLabel.Size = new System.Drawing.Size(20, 22);
            this.topSideLabel.TabIndex = 2;
            this.topSideLabel.Text = "0";
            // 
            // downSideLabel
            // 
            this.downSideLabel.AutoSize = true;
            this.downSideLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downSideLabel.Location = new System.Drawing.Point(370, 419);
            this.downSideLabel.Name = "downSideLabel";
            this.downSideLabel.Size = new System.Drawing.Size(20, 22);
            this.downSideLabel.TabIndex = 3;
            this.downSideLabel.Text = "0";
            // 
            // BilliardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downSideLabel);
            this.Controls.Add(this.topSideLabel);
            this.Controls.Add(this.rightSideLabel);
            this.Controls.Add(this.leftSideLabel);
            this.Name = "BilliardForm";
            this.Text = "Бильярд";
            this.Load += new System.EventHandler(this.BilliardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftSideLabel;
        private System.Windows.Forms.Label rightSideLabel;
        private System.Windows.Forms.Label topSideLabel;
        private System.Windows.Forms.Label downSideLabel;
    }
}

