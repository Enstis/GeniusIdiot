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
        int time = 0;
        int countCatchBall = 0;
        int countCatchBallClick = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int cursorX = e.X;
            int cursorY = e.Y;
            for (int i = 0; i < moveBalls.Count; i++)
            {
                var catchClicBall = moveBalls[i].CatchClickBall(moveBalls[i], cursorX, cursorY);
                if (catchClicBall)
                {
                    moveBalls[i].Stop();
                    moveBalls.Remove(moveBalls[i]);
                    countCatchBallClick++;




                    break;
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
                var catchBall = moveBalls[i].CatchBall(moveBalls[i]);
                if (catchBall) countCatchBallClick++;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            moveBalls = new List<MoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 15)
            {
                timer1.Stop();
                for (int i = 0; i < moveBalls.Count; i++)
                {
                    moveBalls[i].Stop();
                    var catchBall = moveBalls[i].CatchBall(moveBalls[i]);
                    if (catchBall) countCatchBall++;
                }
                if (countCatchBallClick > 0) { MessageBox.Show($"Пойманых шаров: {countCatchBallClick}"); }
                else MessageBox.Show($"Пойманых шаров: {countCatchBall}");

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
