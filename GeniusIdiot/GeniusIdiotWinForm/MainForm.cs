
using GeniusIdiot.Common;

using Microsoft.VisualBasic.ApplicationServices;

namespace GeniusIdiotWinForm
{
    public partial class mainForm : Form
    {
        Game game;
        int timeSecond;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timeSecond = 10;
            

            var enterNameForm = new EnterNameForm();
            enterNameForm.ShowDialog();

            var user = new User(enterNameForm.enterNameTextBox.Text);
            game = new Game(user);

            timer1.Enabled = true;
           
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            timeSecond = 10;
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;

            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);

                if (game.End())
                {
                    timer1.Enabled = false;
                    var message = game.CalculateDiagnose();
                    MessageBox.Show(message);
                    return;
                }
                ShowNextQuestion();
            }
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÂÒÚ‡ÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ÔÓÍ‡Á‡Ú¸“‡·ÎËˆÛ–ÂÁÛÎ¸Ú‡ÚÓ‚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionDel = new QuestionDelForm();
            questionDel.ShowDialog();
        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionAdd = new QuestionAddForm();
            questionAdd.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSecond--;
            countDownLabel.Text = timeSecond.ToString();
            if (timeSecond == 0)
            {
                
                if (countQuestions == 0)
                timeSecond = 10;
                game.AcceptAnswer(0);
                ShowNextQuestion();
            }
        }


    }
}