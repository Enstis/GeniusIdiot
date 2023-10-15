using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class TableResultForm : Form
    {
        public TableResultForm()
        {
            InitializeComponent();
        }



        private void TableResultForm_Load(object sender, EventArgs e)
        {
            var result = UserResultRepository.GetUserResults();
            result.Reverse();

            foreach (var resultItem in result)
            {
                ResultDataGridView.Rows.Add(resultItem.Name, resultItem.Score);
            }
        }
       

    }
}
