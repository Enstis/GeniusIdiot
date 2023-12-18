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
using System.Net.Sockets;

namespace FruitNinjaWindowsFormsApp
{
    public partial class FruitNinjaForm : Form
    {
        Fruit fruit;
        private Timer timer = new Timer();
        private Random rand = new Random();
        private int countBallSalut = 2;
        private int score = 0;
        
        
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

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(fruit.Contains(e.X, e.Y) && fruit.IsMoveable())
            {
                fruit.Stop();
                fruit.Clear();
                score++;
                scoreLabel.Text = score.ToString();
            }
            if (fruit.IsBlack())
            {
                MessageBox.Show("Вы проиграли");
                Refresh();
            }
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
