using BigSalutWindowsFormsApp;
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

namespace FruitNinjaWindowsFormsApp
{
    public partial class FruitNinjaForm : Form
    {
        Fruit fruit;
        private Timer timer = new Timer();
        private Random rand = new Random();
        private int countBallSalut = 2;
        public FruitNinjaForm()
        {
            InitializeComponent();
            timer.Interval = rand.Next(500, 2000);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fruit = new Fruit(this);
            fruit.ChangeColorBrush();
            fruit.Start();
        }

        private void FruitNinjaForm_Load(object sender, EventArgs e)
        {

           
           
           
        }
    }
}
