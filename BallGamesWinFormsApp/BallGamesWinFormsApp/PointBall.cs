namespace BallGamesWinFormsApp
{
    public class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form) 
        {
            this.y = y - size / 2;
            this.x = x - size / 2;
        }

    }
}



