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
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(10, 40);
        }
        public RandomSizeAndPointBall(Form form, Brush brush) : base(form, brush)
        {
            radius = random.Next(10, 40);
        }
    }
    
}
