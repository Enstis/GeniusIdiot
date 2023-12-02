using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball.CommonNet;

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
        
    }
}
