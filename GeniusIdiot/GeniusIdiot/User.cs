public class User
{
    public string Name;
    public int CountRightAnswers;
    public string Diagnose;

    public User(string name)
    {
        Name = name;
        CountRightAnswers = 0;
        Diagnose = "Неизвестен";
    }
}
