using System.Threading.Channels;
using System.IO;
using GeniusIdiot.Common;



//var name = Console.ReadLine();
var repeatTest = true;
do
{
    Console.Write("Введите ваше имя: ");
    var name = Console.ReadLine();
    var user = new User(name);

    var questions = QuestionsStorage.GetAll();
    var countQuation = questions.Count;

    var rnd = new Random();

    for (int i = 0; i < countQuation; i++)
    {
        Console.WriteLine($"Вопрос №{i + 1}");
        var randomIndex = rnd.Next(0, questions.Count);
        Console.WriteLine(questions[randomIndex].Text);
        var rigthAnswer = GetNumber();

        var numberAnswer = questions[randomIndex].Answer;

        if (numberAnswer == rigthAnswer) user.AcceptRightanswers();
        questions.RemoveAt(randomIndex);

    }

    var countDiagnosis = 6;
    user.Diagnose = DiagnoseCalculator.CalculateDiagnosis(countQuation, user.CountRightAnswers);

    Console.WriteLine($"Правильных ответов равно {user.CountRightAnswers}");
    Console.WriteLine($"{user.Name}, Вы - {user.Diagnose}");

    
    UsersResultRepository.Save(user);

    var userChoice = GetUserChoice("Показать таблицу результатов? : ");
    if (userChoice)
    {
        ShowUserResults();
    }
    userChoice = GetUserChoice($"{user.Name}, хотите добавить новый вопрос? :");
    if (userChoice) AddNewQuestion();

    userChoice = GetUserChoice($"{user.Name}, хотите удалить существующий вопрос? :");
    if (userChoice) RemoveQuation();
    repeatTest = GetUserChoice("Хотите снова пройти тест?: ");

} while (repeatTest);

static void RemoveQuation()
{
    Console.WriteLine("Введите номер удаляемого вопроса: ");
    var question = QuestionsStorage.GetAll();
    for (int i = 0; i < question.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {question[i].Text}");
    }
    var removeQuestionNumber = GetNumber();
    while (removeQuestionNumber < 1 || removeQuestionNumber > question.Count)
    {
        Console.WriteLine($"Введите число от 1 до {question.Count}"); ;
        removeQuestionNumber = GetNumber();
    }
    var removeQuestion = question[removeQuestionNumber - 1];
    QuestionsStorage.Remove(removeQuestion);
}




//классы
static bool GetUserChoice(string answer)
{
    Console.WriteLine(answer);
    var userChoise = Console.ReadLine().ToLower();
    if (userChoise == "да") return true;
    return false;
}




static int GetNumber()
{
    while (true)
    {
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.Write("Введите число: ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Вы ввели слишком большое число!");
        }

    }
}
static void ShowUserResults()
{
    var result = UsersResultRepository.GetUserResults();

    Console.WriteLine("|{0,20}|{1,20}|{2,20}|", "Имя", "Кол-во правильных ответов", "Диагноз");

    foreach (var user in result)
    {
        Console.WriteLine("|{0,20}|{1,20}|{2,20}|", user.Name, user.CountRightAnswers, user.Diagnose);
    }
}

static void AddNewQuestion()
{
    Console.Write("Введите текст вопроса: ");
    var text = Console.ReadLine();

    Console.Write("Введите ответ на введенный вопрос:");
    var answer = GetNumber();

    var newQuestuon = new Question(text, answer);

    QuestionsStorage.Add(newQuestuon);

}

