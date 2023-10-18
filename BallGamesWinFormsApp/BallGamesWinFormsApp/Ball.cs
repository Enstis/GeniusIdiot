using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BallGamesWinFormsApp;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        public Ball(MainForm form)
        {
            this.form = form;
        }

        
        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;

            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}



