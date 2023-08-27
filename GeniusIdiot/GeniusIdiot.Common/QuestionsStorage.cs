using System.Collections.Generic;
using GeniusIdiot.Common;
public class QuestionsStorage
{
    public static List<Question> GetAll()
    {
        var questions = new List<Question>();
        if (FileProvider.Exists("fileWithQuestions.txt"))
        {
            var value = FileProvider.GetValue("fileWithQuestions.txt");
            var lines = value.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var lineInFile = line.Split("*");
                var text = lineInFile[0];
                var answer = int.Parse(lineInFile[1]);


                var question = new Question(text, answer);

                questions.Add(question);
            }
        }
        else
        {
            questions.Add(new Question("Сколько будет 2 плюс 2 умноженное на 2 ?", 6));
            questions.Add(new Question("На двух руках 10 пальцев.Сколько палцев на 5 руках ?", 25));
            questions.Add(new Question("Укол делают каждые пол часа. Сколько нужно минут, чтобы сделать 3 укола ?", 60));
            questions.Add(new Question("5 свечей горело, 2 потухли.Сколько осталось?", 2));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов необходимо сделать?", 9));
            SaveQuestions(questions);
        }
        return questions;
    }

    public static void SaveQuestions(List<Question> questions)
    {
        foreach (var question in questions)
        {
            Add(question);
        }
    }

    public static void Add(Question newQuestuon)
    {
        var resultForRecord = $"{newQuestuon.Text}*{newQuestuon.Answer}";
        FileProvider.Append("fileWithQuestions.txt", resultForRecord);
    }

    public static void Remove(Question removeQuestion)
    {
        var questions = GetAll();
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].Text == removeQuestion.Text)
            {
                questions.RemoveAt(i+1);
                break;
            }
        }
        FileProvider.Clear("fileWithQuestions.txt");
        SaveQuestions(questions);
    }

}