using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardBallWindowsFormsApp
{
    public partial class BilliardForm : Form
    {
        public BilliardForm()
        {
            InitializeComponent();
        }

        private void BilliardForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start(); 
            }
        }

        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: 
                    leftSideLabel.Text = (int.Parse(leftSideLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topSideLabel.Text = (int.Parse(topSideLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightSideLabel.Text = (int.Parse(rightSideLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downSideLabel.Text = (int.Parse(downSideLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}
