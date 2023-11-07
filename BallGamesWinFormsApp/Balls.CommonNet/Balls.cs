﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ball.CommonNet
{
    public class Ball
    {
        private Form form;
        protected int centerX = 10;
        protected int centerY = 10;
        protected int radius = 25;

        protected int vx = 1;
        protected int vy = 1;

        private Timer timer;

        public Ball(Form form)
        {
            this.form = form;
            this.form.BackColor = Color.White;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
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
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public void Show()
        {
            var brush = Brushes.Aqua;
            Draw(brush);
        }
        private void Go()
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
        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
