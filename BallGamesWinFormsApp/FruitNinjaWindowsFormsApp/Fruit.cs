using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball.CommonNet;
using BigSalutWindowsFormsApp;

namespace FruitNinjaWindowsFormsApp
{
    public class Fruit : MoveBallRandom
    {
        private float g = 0.2f;
       
        public Fruit(Form form) : base(form)
        {
            radius = random.Next(10, 15);
            vy = -Math.Abs((float)random.NextDouble() * -6 -7);
            centerY = DownSide() + radius;
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));   
            
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            if (centerY >DownSide() + 2*radius)
            {
                Stop();
            }
        }
       
        public bool IsBlack()
        {
           return brush == Brushes.Black;
        }
    }
}
