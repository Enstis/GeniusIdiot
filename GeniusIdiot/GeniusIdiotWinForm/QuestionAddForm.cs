using GeniusIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiotWinForm
{
    public partial class QuestionAddForm : Form
    {
        public QuestionAddForm()
        {
            InitializeComponent();
        }

        private void QuestionAddForm_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var text = newQuestionTextBox.Text;
            var answer = int.Parse(newAnswerTextBox.Text);
            var question = new Question(text, answer);

            QuestionsStorage.Add(question);
            Close();
        }

        private void newAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }

}
