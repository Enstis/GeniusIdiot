using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{

    public class MoveBall : RandomPoinBall
    {
        private Timer timer;
        public MoveBall(MainForm form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start() => timer.Enabled = true;
        
        public void Stop() => timer.Enabled = false; 
    }

}
