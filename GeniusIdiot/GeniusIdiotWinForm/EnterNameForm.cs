using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniusIdiot.Common;

namespace GeniusIdiotWinForm
{
    public partial class EnterNameForm : Form
    {

        public EnterNameForm()
        {
            InitializeComponent();
        }

        private void applyEnteringNameButton_Click(object sender, EventArgs e)
        {
            //mainForm mainForm = new mainForm();
            //mainForm.timer1.Enabled = true;
            Close();
        }

    }
}

