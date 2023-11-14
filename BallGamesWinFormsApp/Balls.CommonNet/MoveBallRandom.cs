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
        public MoveBallRandom(Form form) : base(form)
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
            
        }
        public MoveBallRandom(Form form, Brush brush) : base(form, brush)
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);

        }
    }
    
}
