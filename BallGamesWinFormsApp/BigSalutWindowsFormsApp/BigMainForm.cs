using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball.CommonNet;

namespace BigSalutWindowsFormsApp
{
    public partial class BigMainForm : Form
    {
        private Timer timer = new Timer();
        private Random rand = new Random();
        public BigMainForm()
        {
            InitializeComponent();
        }

        private void BigSalut_Load(object sender, EventArgs e)
        {
            timer.Interval = rand.Next(1000, 10000);
            timer.Tick += Timer_Tick;
            timer.Start();
            

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var ball = new BigSalut(this);
            ball.Start();
        }
    }
}
