using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball.CommonNet
{
    public class BilliardBall : MoveBallRandom
    {
        public event EventHandler<HitEventArgs> OnHited;
        
        public BilliardBall(Form form, Brush brush) : base(form, brush)
        {
            radius = 10;
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
            
        }

        public bool LeftOfCenter ()
        {
            return centerX + radius < form.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius > form.ClientSize.Width / 2;
        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }

        public override void Show()
        {
            base.Show();
            ShowVerticalCenterLine();   
        }

        public void ShowVerticalCenterLine()
        {
            var graphics = form.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 5);
            redPen.DashStyle = DashStyle.Dash;

            graphics.DrawLine(redPen, form.ClientSize.Width/2, 0, form.ClientSize.Width / 2, form.ClientSize.Height);
        }

    }
}
