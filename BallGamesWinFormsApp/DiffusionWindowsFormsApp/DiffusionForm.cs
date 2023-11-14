using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public partial class DiffusionForm : Form
    {
        List<DiffusionBallBlue> blueBalls;
        List<DiffusionBallGreen> greenBalls;
        public DiffusionForm()
        {
            InitializeComponent();
        }

        private void DiffusionForm_Load(object sender, EventArgs e)
        {
            blueBalls = new List<DiffusionBallBlue>();
            greenBalls = new List<DiffusionBallGreen>();

            for (int i = 0; i < 10; i++)
            {
                var greenBall = new DiffusionBallGreen(this);
                greenBall.Show();
                greenBall.OnHited += GreenBall_OnHited;
                greenBalls.Add(greenBall);
                
                var blueBall = new DiffusionBallBlue(this);
                blueBall.Show();
                blueBall.OnHited += BlueBall_OnHited;
                blueBalls.Add(blueBall);
                
            }
            
        }

        private void BlueBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftSideBlueLabel.Text = (int.Parse(leftSideBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topSideBlueLabel.Text = (int.Parse(topSideBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightSideBlueLabel.Text = (int.Parse(rightSideBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downSideBlueLabel.Text = (int.Parse(downSideBlueLabel.Text) + 1).ToString();
                    break;
            }
            bool countGreen = int.Parse(leftSideGreenLabel.Text) > 20 && int.Parse(topSideGreenLabel.Text) > 20 && int.Parse(rightSideGreenLabel.Text) > 20 && int.Parse(downSideGreenLabel.Text) > 20;
            bool countBlue = int.Parse(leftSideBlueLabel.Text) > 20 && int.Parse(topSideBlueLabel.Text) > 20 && int.Parse(rightSideBlueLabel.Text) > 20 && int.Parse(downSideBlueLabel.Text) > 20;
            if (countBlue && countGreen)
            {
                for (int i = 0; i < greenBalls.Count; i++)
                {
                    greenBalls[i].Stop();
                    blueBalls[i].Stop();
                }
            }
        }

        private void GreenBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftSideGreenLabel.Text = (int.Parse(leftSideGreenLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topSideGreenLabel.Text = (int.Parse(topSideGreenLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightSideGreenLabel.Text = (int.Parse(rightSideGreenLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downSideGreenLabel.Text = (int.Parse(downSideGreenLabel.Text) + 1).ToString();
                    break;
            }
        }



        //protected override void OnPaint(PaintEventArgs e) 
        //{
        //    base.OnPaint(e);
        //    Graphics dc = e.Graphics;
        //    Pen pen = new Pen(Color.Red, 5);
        //    pen.DashStyle = DashStyle.Dash;
        //    int x1 = ClientSize.Width / 2;
        //    int y1 = 0;
        //    int x2 = x1;
        //    int y2 = ClientSize.Height;
        //    dc.DrawLine(pen, x1, 0, x2, y2);
        //}

        private void DiffusionForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < greenBalls.Count; i++)
            {
                if (greenBalls[i].timer.Enabled == false || blueBalls[i].timer.Enabled == false)
                {
                    greenBalls[i].Start();
                    blueBalls[i].Start();
                }
                else
                {
                    greenBalls[i].Stop();
                    blueBalls[i].Stop();
                }
            }
                
        }
    }
}
