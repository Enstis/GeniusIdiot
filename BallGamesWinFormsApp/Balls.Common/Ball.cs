using System.Drawing;
using System.Windows.Forms;


namespace Ball.Common
{
    public class Ball
    {
        private Form form;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        protected int vx = 1;
        protected int vy = 1;

        public Ball(Form form)
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
        public bool Contains(int pointX, int pointY)
        {
            var radius = size / 2;
            var centerX = x + radius;
            var centerY = y + radius;

            return (centerX - pointX) * (centerX - pointX) + (centerY - pointY) * (centerY - pointY) <= radius * radius;
           
        }
    }
}

