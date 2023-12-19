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


namespace CatchBallWindowsFormsApp2
{
    public partial class MainFormClick : Form
    {
        List<MoveBallRandom> moveBallsRandom;
        private int countCatchBall = 0;
        public MainFormClick()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            clearButton.Enabled = true;

            moveBallsRandom = new List<MoveBallRandom>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBallRandom(this);
                moveBallsRandom.Add(moveBall);
                moveBall.Start();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            countCatchBall = 0;
            foreach (var ball in moveBallsRandom)
            {
               ball.Clear();
            }

        }

        private void MainFormClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBallsRandom != null)
            {
                foreach (var ball in moveBallsRandom)
                {
                    if (ball.IsMoveable() && ball.Contains(e.X, e.Y))
                    {
                        countCatchBall++;
                        ball.Stop();
                    }

                }
                countBallsLabel.Text = countCatchBall.ToString();
            }
        }

        private void MainFormClick_Load(object sender, EventArgs e)
        {

        }
    }
}
