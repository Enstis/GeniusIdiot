using System.Threading.Channels;
using System.IO;

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
User user = new User(name);


//var name = Console.ReadLine();
var repeatTest = true;
do
{
    var questions = new QuestionsStorage().Quations;
    var countQuation = questions.Count;
   
    var rnd = new Random();
    
    for (int i = 0; i < countQuation; i++)
    {
        Console.WriteLine($"Вопрос №{i + 1}");
        var randomIndex = rnd.Next(0,questions.Count);
        Console.WriteLine(questions[randomIndex].Text);
        var rigthAnswer = QuestionsStorage.GetNumberAnswer();
        
        var numberAnswer = questions[randomIndex].Answer;

        if (numberAnswer == rigthAnswer) user.CountRightAnswers++;
        questions.RemoveAt(randomIndex);
        
    }
    
    var countDiagnosis = 6;
    user.Diagnose = CalculateDiagnosis(countQuation, user.CountRightAnswers);
    
    Console.WriteLine($"Правильных ответов равно {user.CountRightAnswers}");
    Console.WriteLine($"{user.Name}, Вы - {user.Diagnose}");
    
    // начало работы с файлом
        UsersResultRepository usersResultRepository = new UsersResultRepository(user);
    usersResultRepository.SaveUserResult();

    var userChoice = GetUserChoice("Показать таблицу результатов? : ");
    if (userChoice)
    {
        usersResultRepository.OutPutResult();      
    }

    repeatTest = GetUserChoice($"{user.Name}, хотите снова пройти тест? : ");
    
} while (repeatTest);

//классы
static bool GetUserChoice(string answer)
{
    Console.WriteLine(answer);
    var userChoise = Console.ReadLine().ToLower();
    if (userChoise == "да") return true;
    return false;
}


static string CalculateDiagnosis(int countQuation, int countAnswers)
{
    var diagnoses = GetDiagnosis();
    var percenRightanswers = countAnswers * 100 / countQuation;

    return diagnoses[percenRightanswers / 20];
}

Console.ReadKey();


static  List<string> GetDiagnosis()
{
    var diagnosis = new List<string>();
    diagnosis.Add("Идиот");
    diagnosis.Add("Кретин");
    diagnosis.Add("Дурак");
    diagnosis.Add("Нормальный");
    diagnosis.Add("Талант");
    diagnosis.Add("Гений");
    return diagnosis;
};
