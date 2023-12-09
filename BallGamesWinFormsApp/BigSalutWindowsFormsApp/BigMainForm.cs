using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ball.CommonNet;
using SalutWindowsFormsApp;

namespace BigSalutWindowsFormsApp
{

    public partial class BigMainForm : Form
    {
        private List<BigSalut> bigSalutList = new List<BigSalut>();
     
        private Timer timer = new Timer();
        private Timer timerBoom = new Timer();
        private Random rand = new Random();
        private int countBallSalut = 0;
        private int count = 0;
        private int numBallSalut = 0;
        public BigMainForm()
        {
            InitializeComponent();

            timer.Interval = rand.Next(4000, 5000);
            timer.Tick += Timer_Tick;
            

        }

        private void BigSalut_Load(object sender, EventArgs e)
        {

            countBallSalut = rand.Next(3, 7);
            for (int i = 0; i < countBallSalut; i++)
            {
                var ball = new BigSalut(this);
                ball.ChangeColorBrush();
                ball.HitLine += Ball_HitLine;
                bigSalutList.Add(ball);
            }
                timer.Start();
        }

        private void Ball_HitLine(object sender, HitLineEventArgs e)
        {
            switch (e.CrossLine)
            {
                case CrossLine.MiddleY:


                    bigSalutList[numBallSalut].Stop();
                    bigSalutList[numBallSalut].Clear();

                    float x = bigSalutList[numBallSalut].BallX();
                    float y = bigSalutList[numBallSalut].BallY();

                    var count = rand.Next(5, 11);
                    for (int i = 0; i < count; i++)
                    {
                        var salut = new SalutBall(this, x, y);
                        salut.ChangeColorBrush();
                        salut.Start();
                    }
                    numBallSalut++;
                    break;

            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (count != countBallSalut - 1)
            {
                bigSalutList[count].Start();

                count++;
            }

        }
  
    }
}
