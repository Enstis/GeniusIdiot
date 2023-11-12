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
        }
        



    }
}
