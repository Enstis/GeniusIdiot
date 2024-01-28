using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public class BirdBall : MoveBallRandom
    {
        private float gy = 0.1f;
        private float elastic = 0.3f;
       

        public BirdBall(Form form) : base(form)
        {
            radius = 15;
            centerX = LeftSide(); 
            centerY = DownSide();
            brush = Brushes.Red;
            vy = 0;
            vx = 0;
        }

        protected override void Go()
        {
            base.Go();
            vy += gy;

            if (centerY >DownSide())
            {
                centerY = DownSide();
                vy = -vy * elastic;
                vx = vx * elastic;
            }
            if ( vx < 0.1 && vy < 0.1 )
            {
                Stop();
               
            }
        }
        public bool IsOutSide()
        {
            return centerX > RightSide();
        }


        public void DeterminationSpeed(int X, int Y)
        {

            vy = (Y - centerY) / 20;
            vx = (X - centerX) / 20;
        }
    }
}
