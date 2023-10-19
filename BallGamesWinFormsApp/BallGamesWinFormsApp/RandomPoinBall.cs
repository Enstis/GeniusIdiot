namespace BallGamesWinFormsApp
{
    public class RandomPoinBall : Ball
    {
        protected Random random = new Random();

        public RandomPoinBall(MainForm form) : base(form)  
        {
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }
    
}
