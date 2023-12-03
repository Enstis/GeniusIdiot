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
        public BigMainForm()
        {
            InitializeComponent();
            timer.Start();
            timer.Interval = rand.Next(4000, 8001);
            timer.Tick += Timer_Tick;

           

        }

        private void BigSalut_Load(object sender, EventArgs e)
        {
            timerBoom.Start();
            timerBoom.Tick += TimerBoom_Tick;

            countBallSalut = rand.Next(3, 7);
            for (int i = 0; i < countBallSalut; i++)
            {
                var ball = new BigSalut(this);
                ball.ChangeColorBrush();
                bigSalutList.Add(ball);             
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
        private void TimerBoom_Tick(object sender, EventArgs e)
        {
            foreach (var ball in bigSalutList)
            {
                if(ball.CrossBoomHorizontalLine())
                {
                    ball.Stop();
                    ball.Clear();

                    float x = ball.BallX();
                    float y = ball.BallY();

                    var count = rand.Next(1, 11);
                    for (int i = 0; i < count; i++)
                    {
                        var salut = new SalutBall(this, x, y);
                        salut.Start();
                    }
                    timerBoom.Stop();
                    
                }
               
            }
        }
    }
}
