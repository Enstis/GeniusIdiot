
using GeniusIdiot.Common;

using Microsoft.VisualBasic.ApplicationServices;

namespace GeniusIdiotWinForm
{
    public partial class mainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int countQuestions;
        private int questionNumber;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            user = new User("Неизвестно");
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
            questionNumber = 0;
            ShowNextQuestion();
           
        }

        private void ShowNextQuestion()
        {
            var rnd = new Random();
            var randomIndex = rnd.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];

            questionTextLabel.Text = currentQuestion.Text;

            questionNumber++;
            questionNumberLabel.Text = $"Вопрос №{questionNumber}";
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = int.Parse(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (rightAnswer == userAnswer) user.AcceptRightanswers();
            questions.Remove(currentQuestion);


            var endGame = questions.Count == 0;
            if (endGame) 
            {
                user.Diagnose = DiagnoseCalculator.CalculateDiagnosis(countQuestions, user.CountRightAnswers);
                MessageBox.Show($"{user.Name}, Ваш диагноз {user.Diagnose}");
                return;
            }
            
            ShowNextQuestion();
        }
    }
}