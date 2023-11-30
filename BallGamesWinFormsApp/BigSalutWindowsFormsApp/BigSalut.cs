using System;
using System.Collections.Generic;
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
    }
}
