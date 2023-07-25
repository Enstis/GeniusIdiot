public class QuestionsStorage
{
    public Questions Quations;
    public List<Questions> QuestionsList;

    public QuestionsStorage()
    {
        QuestionsList  = new List<Questions>();
        ReadofFileQuestion();
    }
    public QuestionsStorage(Questions quations)
    {
        Quations = quations;
    }
        public int GetNumberAnswer()
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


    public void ReadofFileQuestion()
    {
        using (var sr = new StreamReader("fileWithQuestions.txt"))
        {
            while (!sr.EndOfStream)
            {
                var lineInFile = sr.ReadLine().Split("*");
                var quationText = lineInFile[0];
                var rightAnswer = int.Parse(lineInFile[1]);
                Questions quation = new Questions(quationText, rightAnswer);
                QuestionsList.Add(quation);
            }

        }
    }
    //public void QuationAdd()
    //{
    //    Console.Write("Введите текст вопроса: ");
    //    string enterQuation = Console.ReadLine();

    //    Console.Write("Введите ответ на введенный вопрос: ");
    //    int answer = int.Parse(Console.ReadLine());
    //    Quations quation = new Quations(enterQuation,answer);
    //    Quations.Add(quation);
    //}
    //public void QuationDelete()
    //{
    //    int i = 0;
       
    //    foreach (Quations quation in Quations)
    //    {
    //        Console.Write($"{i})");
    //        Console.WriteLine(quation);
    //        i++;
    //    }
    //    Console.Write("Введите номер вопроса для его удаления: ");
    //    int index = int.Parse(Console.ReadLine());
    //    Quations.RemoveAt(index);
    //    }
}