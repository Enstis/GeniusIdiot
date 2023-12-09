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
        public event EventHandler<HitLineEventArgs> HitLine;
        public BigSalut(Form form) : base(form)
        {
            centerY = DownSide() + radius;
            vx = 0;
            vy = -Math.Abs(2);
            radius = 5;
            

        }
        
        public bool CrossBoomHorizontalLine()
        {
            if (centerY <= DownSide() / 2) 
            {
                return true;
            }
            return false;
        }
        protected override void Go()
        {
            base.Go();
            if (CrossBoomHorizontalLine())
            {
                HitLine.Invoke(this, new HitLineEventArgs(CrossLine.MiddleY));
            }
        }
        public float BallX()
        {
            return centerX;
        }
        public float BallY()
        {
            return centerY;
        }
    }
}
