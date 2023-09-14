using System.Collections.Generic;
using GeniusIdiot.Common;
using Newtonsoft.Json;

public class QuestionsStorage
{
    public static string Path = "fileWithQuestions.json";
    public static List<Question> GetAll()
    {
        var questions = new List<Question>();
        if (FileProvider.Exists(Path))
        {
            var value = FileProvider.GetValue(Path);
            questions = JsonConvert.DeserializeObject<List<Question>>(value);
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
        var jsonData = JsonConvert.SerializeObject(questions);
        FileProvider.Append(Path, jsonData);

    }

    public static void Add(Question newQuestuon)
    {
        var question = GetAll();
        question.Add(newQuestuon);
        SaveQuestions(question);
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
        SaveQuestions(questions);
    }

}