public class UsersResultRepository
{
    public User User;

    public UsersResultRepository (User user)
    {
        User = user;
    }
    public void SaveUserResult()
    {
        var resultForRecord = $"{User.Name}*{User.CountRightAnswers}*{User.Diagnose}"; //создаем шаблон для добавления в файл
        AppendToFile("tableResult.txt", resultForRecord);

    }
    static void AppendToFile(string textFileName, string resultForRecord)   //добавляем значение в файл
    {
        using (var tableResult = new StreamWriter(textFileName, true, System.Text.Encoding.Default))
        {
            tableResult.WriteLine(resultForRecord);
        }
    }
    public void OutPutResult()
    {
        using (var sr = new StreamReader("tableResult.txt"))
        {
            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|", "Имя", "Баллы", "Диагноз"));
            while (!sr.EndOfStream)
            {
                var lineInFile = sr.ReadLine().Split("*");
                var name = lineInFile[0];
                var countrRightAnswer = int.Parse(lineInFile[1]);
                var diagnose = lineInFile[2];
                Console.WriteLine("|{0,10}|{1,10}|{2,10}|", name, countrRightAnswer, diagnose);
            }

        }
    }
}