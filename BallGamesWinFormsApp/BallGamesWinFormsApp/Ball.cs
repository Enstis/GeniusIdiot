using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BallGamesWinFormsApp;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        public Ball(MainForm form)
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;

            var rectangle = new Rectangle(150, 150, 100, 100);
            graphics.FillEllipse(brush, rectangle);
        }
       
    }
}

public class RandomPointBall
{
    static Random random = new Random();
    public RandomPointBall(MainForm form)
    {
        var graphics = form.CreateGraphics();
        var brush = Brushes.Aqua;
        var x = random.Next(0, form.ClientSize.Width);
        var y = random.Next(0, form.ClientSize.Height);


        var rectangle = new Rectangle(x, y, 100, 100);
        graphics.FillEllipse(brush, rectangle);
    }

}
