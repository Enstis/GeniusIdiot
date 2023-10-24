using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        RandomSizeAndPointBall randomSizeAndPointBall;
        PointBall pointBall;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var countCatchBall = 0;
            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
                var catchBall = moveBalls[i].CatchBall(moveBalls[i]);
                if (catchBall) countCatchBall++;
                

            }

            MessageBox.Show($"Пойманых шаров: {countCatchBall}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }

        }
    }
}
