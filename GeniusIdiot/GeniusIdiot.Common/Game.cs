using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot.Common
{
    
    public class Game
    {
        private List<Question> questions;
        public Question currentQuestion;
        private User user;
        static int countQuestions;
        private int questionNumber = 0;
        public Game(User user)
        {
            this.user=user;
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
        }
        public Question GetNextQuestion() 
        {
            var rnd = new Random();
            var randomIndex = rnd.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];

            questionNumber++;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (rightAnswer == userAnswer) user.AcceptRightanswers();
            questions.Remove(currentQuestion);
        }
        public string GetQuestionNumberText()
        {
            return $"Вопрос №{questionNumber}";
        }

        public bool End()
        {
            return questions.Count == 0;
        }
        public string CalculateDiagnose()
        {
            user.Diagnose = DiagnoseCalculator.Calculate(countQuestions, user.CountRightAnswers);
            UsersResultRepository.Save(user);
            return $"{user.Name}, Ваш диагноз {user.Diagnose}";
        }
    }
}
