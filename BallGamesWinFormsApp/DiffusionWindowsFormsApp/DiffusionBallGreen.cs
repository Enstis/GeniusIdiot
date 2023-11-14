using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class DiffusionBallGreen : BilliardBall
    {
        
        public DiffusionBallGreen(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), CenterRightSide());
            centerY = random.Next(TopSide(), DownSide());
        }

        public override void Show()
        {
            var brush = Brushes.Green;
            
            Draw(brush);
            var  graphics = form.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);
            pen.DashStyle = DashStyle.Dash;
            int x1 = form.ClientSize.Width / 2;
            int y1 = 0;
            int x2 = x1;
            int y2 = form.ClientSize.Height;
            graphics.DrawLine(pen, x1, 0, x2, y2);
        }
        



    }
}
