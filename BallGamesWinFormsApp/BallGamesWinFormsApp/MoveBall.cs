using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{

    public class MoveBall : RandomSizeAndPointBall
    {
        private Timer timer;

        public MoveBall(MainForm form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ChangeMoveBall();
            Move();
        }

        public bool CatchClickBall(MoveBall moveBall, int cursorX, int cursorY)
        {
            var xCatchBallClick = cursorX >= moveBall.x && cursorX <= moveBall.x + size;
            var yCatchBallClick = cursorY >= moveBall.y && cursorY <= moveBall.y + size;

            return xCatchBallClick && yCatchBallClick;
        }
        public bool CatchBall (MoveBall moveBall)
        {
            var xCatchBall = moveBall.x >= 0 && moveBall.x + size <= form.ClientSize.Width;
            var yCatchBall = moveBall.y >= 0 && moveBall.y + size <= form.ClientSize.Height;

            return xCatchBall && yCatchBall;
        }
        public void ClearClickBall(MoveBall moveBall)
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(moveBall.x, moveBall.y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void ChangeMoveBall ()
        {
            if (x > form.ClientSize.Width * 1.5 || x <= -form.ClientSize.Width * 1.5)
            {
                vx *= -1;
            }
            if(y > form.ClientSize.Height * 1.5 || y <= -form.ClientSize.Height * 1.5 )
            {
                vy *= -1;
            }
            
        }
        
        public void Start() => timer.Enabled = true;
        
        public void Stop() => timer.Enabled = false; 
    }

}
