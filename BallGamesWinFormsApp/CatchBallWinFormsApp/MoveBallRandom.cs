using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace CatchBallWinFormsApp
{
    public class MoveBallRandom : RandomSizeAndPointBall
    {
        private Timer timer;
        public MoveBallRandom(MainForm form) : base(form)
        {
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

       
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

       
        
    }

}
