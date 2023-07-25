public class QuestionsStorage
{
    public List<Quations> Quations;

    public QuestionsStorage()
    {
        Quations = new List<Quations>
        {
            new Quations("Сколько будет 2 плюс 2 умноженное на 2?", 6),
            new Quations("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
            new Quations("На двух руках 10 пальцев. Сколько палцев на 5 руках?", 25),
            new Quations("Укол делают каждые пол часа. Сколько нужно минут, чтобы сделать 3 укола?", 60),
            new Quations("5 свечей горело, 2 потухли. Сколько осталось?", 2),
        };

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
    public void QuationAdd()
    {
        Console.Write("Введите текст вопроса: ");
        string enterQuation = Console.ReadLine();

        Console.Write("Введите ответ на введенный вопрос: ");
        int answer = int.Parse(Console.ReadLine());
        Quations quation = new Quations(enterQuation,answer);
        Quations.Add(quation);
    }
    public void QuationDelete()
    {
        int i = 0;
       
        foreach (Quations quation in Quations)
        {
            Console.Write($"{i})");
            Console.WriteLine(quation);
            i++;
        }
        Console.Write("Введите номер вопроса для его удаления: ");
        int index = int.Parse(Console.ReadLine());
        Quations.RemoveAt(index);
        }
}