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
using System.Runtime.CompilerServices;

namespace GeniusIdiotWinForm
{
    public partial class QuestionDelForm : Form
    {
        
        public QuestionDelForm()
        {
            InitializeComponent();
        }
        
        private void QuestionDelForm_Load(object sender, EventArgs e)
        {
            
            var results = QuestionsStorage.GetAll();
            foreach (var result in results)
            {
                resultsForRemoveQuestiondataGridView.Rows.Add(result.Text);
            }
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var rowRemove = resultsForRemoveQuestiondataGridView.CurrentRow.Index;
            var questions = QuestionsStorage.GetAll();
            questions.RemoveAt(rowRemove);

            FileProvider.Clear("fileWithQuestions.txt");
            QuestionsStorage.SaveQuestions(questions);
           

            resultsForRemoveQuestiondataGridView.Rows.Clear();
            QuestionDelForm_Load(sender, e);
        }
        
        
    }
}
