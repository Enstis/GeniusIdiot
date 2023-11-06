namespace CatchBallWinFormsApp
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form) 
        {
            size = random.Next(20, 70);
        }
    }
}

