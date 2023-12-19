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
        Random random = new Random();
        public Fruit(Form form) : base(form)
        {
            radius = random.Next(10, 30);
            vy = -Math.Abs((float)random.NextDouble() * 10 - 15);
            centerY = DownSide() + radius;
            
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
       
        public bool IsBlack()
        {
           return brush == Brushes.Black;
        }
    }
}
