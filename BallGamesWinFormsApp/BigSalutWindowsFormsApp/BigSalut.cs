using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball.CommonNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BigSalutWindowsFormsApp
{
    
    public class BigSalut : MoveBallRandom
    {
        
        public BigSalut(Form form) : base(form)
        {
            centerY = DownSide() + radius;
            vx = 0;
            vy = -Math.Abs(2);
            radius = 5;
            

        }
        public void ChangeColorBrush()
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
        }
        public bool CrossBoomHorizontalLine()
        {
            if (centerY < form.ClientSize.Height / 2) 
            {
                return true;
            }
            return false;
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
