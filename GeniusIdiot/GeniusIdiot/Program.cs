using System.Threading.Channels;
using System.IO;


var result = "";
Console.Write("Введите ваше имя: ");
var name = Console.ReadLine();
var repeatTest = true;
do
{

    var quation = GetQuations();
    var countQuation = quation.Count;
    var answers = GetAnswer();

   
    var rnd = new Random();
    var countAnswers = 0;
    for (int i = 0; i < quation.Count; i++)
    {
        Console.WriteLine($"Вопрос №{i + 1}");
        var randomQuationsIndex = rnd.Next(0,quation.Count);
        Console.WriteLine(quation[randomQuationsIndex]);

        var numberAnswer = answers[randomQuationsIndex];

        if (numberAnswer == answers[i]) countAnswers++;
        quation.RemoveAt(randomQuationsIndex);
        answers.RemoveAt(randomQuationsIndex);
    }

    var countDiagnosis = 6;
    var diagnose = CalculateDiagnosis(countQuation, countAnswers);
     Console.WriteLine($"Правильных ответов равно {countAnswers}");
    Console.WriteLine($"{name}, Вы - {diagnose}");


    // начало работы с файлом


    SaveUserResult(name, countAnswers, diagnose);

    var userChoice = GetUserChoice("Показать таблицу результатов? : ");
    if (userChoice)
    {
        OutPutResult();      
    }

    repeatTest = GetUserChoice($"{name}, хотите снова пройти тест? : ");
    
} while (repeatTest);



///Функции
static void OutPutResult()
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

static bool GetUserChoice(string answer)
{
    Console.WriteLine(answer);
    var userChoise = Console.ReadLine().ToLower();
    if (userChoise == "да") return true;
    return false;
}

static void SaveUserResult(string name, int countAnswers, string diagnose) 
{
    var resultForRecord = $"{name}*{countAnswers}*{diagnose}"; //создаем шаблон для добавления в файл
    AppendToFile("tableResult.txt", resultForRecord);      
    
}
static void AppendToFile (string textFileName, string resultForRecord)   //добавляем значение в файл
{
    using (var tableResult = new StreamWriter(textFileName, true, System.Text.Encoding.Default))
    {
        tableResult.WriteLine(resultForRecord);
    }
}

static string CalculateDiagnosis(int countQuation, int countAnswers)
{
    var diagnoses = GetDiagnosis();
    var percenRightanswers = countAnswers * 100 / countQuation;

    return diagnoses[percenRightanswers / 20];
}

Console.ReadKey();

static List<string> GetQuations()
{
    var quation = new List<string>();

    quation.Add( "Сколько будет 2 плюс 2 умноженное на 2?");
    quation.Add("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?");
    quation.Add("На двух руках 10 пальцев. Сколько палцев на 5 руках?");
    quation.Add("Укол делают каждые пол часа. Сколько нужно минут, чтобы сделать 3 укола?");
    quation.Add("5 свечей горело, 2 потухли. Сколько осталось?");

    return quation;
};

static List<int> GetAnswer()
{
    var answers = new List<int>();
    answers.Add(6);
    answers.Add(9);
    answers.Add(25);
    answers.Add(60);
    answers.Add(2);
    return answers;
};

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

static int GetNumberAnswer()
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