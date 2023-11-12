using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class DiffusionBallBlue : BilliardBall
    {
        public DiffusionBallBlue(Form form) : base(form)
        {
            centerX = random.Next(CenterLeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
        public override void Show()
        {
            var brush = Brushes.Blue;
            Draw(brush);
        }
    }
}
