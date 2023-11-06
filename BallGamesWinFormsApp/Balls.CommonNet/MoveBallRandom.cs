using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball.CommonNet
{
    
    public class MoveBallRandom : RandomSizeAndPointBall
    {
        public Timer timer;
        public MoveBallRandom(Form form) : base(form)
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Stop();


        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public bool IsMoveable()
        {
            return timer.Enabled;
        }
    }
    
}
