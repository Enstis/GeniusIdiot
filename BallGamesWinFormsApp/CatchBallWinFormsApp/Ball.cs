using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CatchBallWinFormsApp
{
    public class Ball
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        protected int vx = 1;
        protected int vy = 1;

        public Ball(MainForm form)
        {
            this.form = form;
            this.form.BackColor = Color.White;
        }
        public bool CatchBall(MoveBallRandom moveBallRandom)
        {
            bool positionX = moveBallRandom.x > 0 && moveBallRandom.x + size < form.ClientSize.Width;
            bool positionY = moveBallRandom.y > 0 && moveBallRandom.y + size < form.ClientSize.Height;

            return positionX && positionY;
        }
        public void Move ()
        {
            Clear();
            Go();
            Show();
        }
        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}

