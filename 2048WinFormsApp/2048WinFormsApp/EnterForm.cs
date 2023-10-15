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

    public partial class EnterForm : Form
    {
        public int sizeNumber;
        public EnterForm()
        {
            InitializeComponent();
        }
        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }


        public void okButton_Click(object sender, EventArgs e)
        {
            string size = mapSizeComboBox.Text.ToString();

            if (size == string.Empty)
            {
                MessageBox.Show("Введите размер поля");
                return;
            }
            else
            {
                sizeNumber = int.Parse(size.Substring(0, 1));

            }
            Close();

        }


    }



}
