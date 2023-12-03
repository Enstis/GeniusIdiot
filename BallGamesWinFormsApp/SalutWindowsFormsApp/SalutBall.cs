using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public class SalutBall : MoveBallRandom
    {
        private float g = 0.2f;
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            radius = 5;
            brush = Brushes.Green;
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
