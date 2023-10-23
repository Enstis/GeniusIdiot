using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{

    public class MoveBall : RandomSizeAndPointBall
    {
        private Timer timer;

        public MoveBall(MainForm form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ChangeMoveBall();
            Move();
        }

        public void ChangeMoveBall ()
        {
            if (x> form.ClientSize.Width || x < 0)
            {
                vx *= -1;
            }
            if(y > form.ClientSize.Height || y < 0)
            {
                vy *= -1;
            }
            
        }
        
        public void Start() => timer.Enabled = true;
        
        public void Stop() => timer.Enabled = false; 
    }

}
