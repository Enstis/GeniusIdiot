namespace _2048WinFormsApp
{
    public class ScoreComparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.scoreUser.CompareTo(y.scoreUser);
        }

    }
}