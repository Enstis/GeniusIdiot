namespace BallGamesWinFormsApp
{
    public class RandomSizeAndPointBall : RandomPoinBall
    {
        public RandomSizeAndPointBall(MainForm form) : base(form)
        {
           size = random.Next(10, 70);   
        }
    }
    
}
