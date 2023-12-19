using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball.CommonNet;
using SalutWindowsFormsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BigSalutWindowsFormsApp
{
    
    public class BigSalut : MoveBallRandom
    {
        private float g = 0.2f;
        public event EventHandler<HitLineEventArgs> HitLine;
        public BigSalut(Form form) : base(form)
        {
            centerY = DownSide() + radius;
            vx = 0;
            vy = (float)random.NextDouble() * -6 -5;
            radius = 5;
            

        }
        
       
        protected override void Go()
        {
            base.Go();
            vy += g;
            if (vy > 0)
            {
                Stop();
                Clear();
                HitLine?.Invoke(this, new HitLineEventArgs(centerX,centerY));
            }
        }
       
    }
}
