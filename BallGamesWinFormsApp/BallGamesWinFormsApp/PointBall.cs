namespace BallGamesWinFormsApp
{
    public class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form) 
        {
            this.x = x;
            this.y = y;
        }
    }
    
}
