public class UsersResultRepository
{

    public static void Save(User user)
    {
        var resultForRecord = $"{user.Name}*{user.CountRightAnswers}*{user.Diagnose}"; 
        FileProvider.Append("tableResult.txt", resultForRecord);

    }

    public static List<User> GetUserResults()
    {

        var value = FileProvider.GetValue("tableResult.txt");
        var lines = value.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
        var results = new List<User>();

        foreach (var line in lines)
        {
            var lineInFile = line.Split("*");
            var name = lineInFile[0];
            var countrRightAnswer = int.Parse(lineInFile[1]);
            var diagnose = lineInFile[2];

            var user = new User(name);
            user.CountRightAnswers = countrRightAnswer;
            user.Diagnose = diagnose;
            results.Add(user);
        }


        return results;
    }
}