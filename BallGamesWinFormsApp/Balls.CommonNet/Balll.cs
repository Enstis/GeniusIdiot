using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ball.CommonNet
{
    public class Balll
    {
        protected Random random = new Random();
        protected Form form;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 25;

        protected Brush brush = Brushes.Black;
        
        protected float vx = 1;
        protected float vy = 1;

        public Timer timer;

        public Balll(Form form)
        {
            this.form = form;
            this.form.BackColor = Color.White;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public Balll(Form form, Brush brush)
        {
            this.form = form;
            this.form.BackColor = Color.White;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            this.brush = brush;
        }

        public Brush GetBrush()
        {
            return brush;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public bool IsMoveable()
        {
            return timer.Enabled;
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

        public bool CatchBall()
        {
            bool positionX = centerX > 0 && centerX + radius < form.ClientSize.Width;
            bool positionY = centerY > 0 && centerY + radius < form.ClientSize.Height;

            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public int CenterRightSide()
        {
            return form.ClientSize.Width / 2 - radius;
        }
        public int CenterLeftSide()
        {
            return radius + form.ClientSize.Width / 2;
        }
        
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public virtual void Show()
        {
            Draw(brush);
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        public void Clear()
        {
            var brush = Brushes.White;
            Draw(brush);
        }
        public bool Contains(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx * dx + dy * dy <= radius * radius;
        }
        protected virtual void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle((int)centerX - radius, (int)centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
        public void ChangeColorBrush()
        {
            //brush = new SolidBrush(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
            brush = new SolidBrush(Color.FromArgb(0, 0, 0));
        }
    }
}
