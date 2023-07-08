Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
bool agreeRepeatTest;
do
{
    int valueQuation = 5;
    string[] quation = GetQuations();
    int[] answers = GetAnswer();
    
    //начало перемешинвания массива вопросов и ответов
    Random rnd = new Random();
    int randomNumber;
    string tempString;
    int tempInt;
    for (int i = answers.Length - 1; i > 0; i--)
    {
        randomNumber = rnd.Next(i + 1);

        tempString = quation[randomNumber];
        quation[randomNumber] = quation[i];
        quation[i] = tempString;

        tempInt = answers[randomNumber];
        answers[randomNumber] = answers[i];
        answers[i] = tempInt;
               
    }

    int countAnswers = 0;
    for (int i = 0; i < quation.Length; i++)
    {
        Console.WriteLine($"Вопрос №{i + 1}");
        Console.WriteLine(quation[i]);
        
            char numCharAnswer = Convert.ToChar(Console.ReadLine());
        int numberAnswer = ItNumber(numCharAnswer);
            

        if (numberAnswer == answers[i]) countAnswers++;
    }

    int countDiagnosis = 6;
    string[] diagnoses = GetDiagnosis();
    Console.WriteLine($"Правильных ответов равно {countAnswers}");
    Console.WriteLine($"{name}, Вы - {diagnoses[countAnswers]}");

    Console.Write($"{name}, хотите снова пройти тест? : ");
    string repeatTest = Console.ReadLine().ToLower();
    agreeRepeatTest = repeatTest == "да" ? true : false;
} while (agreeRepeatTest);




///Функции

static int ItNumber (char number)
{
    bool trueNumber = char.IsDigit(number);
    while (!trueNumber)
    {
        Console.Write("Введите число: ");
        number = Convert.ToChar(Console.ReadLine());
        trueNumber = char.IsDigit(number);
    }
    return (int)number;
}
static string[] GetQuations()
{
    string[] quation = new string[5];

    quation[0] = "Сколько будет 2 плюс 2 умноженное на 2?";
    quation[1] = "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?";
    quation[2] = "На двух руках 10 пальцев. Сколько палцев на 5 руках?";
    quation[3] = "Укол делают каждые пол часа. Сколько нужно минут, чтобы сделать 3 укола?";
    quation[4] = "5 свечей горело, 2 потухли. Сколько осталось?";

    return quation;
};

static int[] GetAnswer()
{
    int[] answers = new int[5];
    answers[0] = 6;
    answers[1] = 9;
    answers[2] = 25;
    answers[3] = 60;
    answers[4] = 2;
    return answers;
};

static string[] GetDiagnosis()
{
    string[] diagnosis = new string[6];
    diagnosis[0] = "Идиот";
    diagnosis[1] = "Кретин";
    diagnosis[2] = "Дурак";
    diagnosis[3] = "Нормальный";
    diagnosis[4] = "Талант";
    diagnosis[5] = "Гений";
    return diagnosis;
};

