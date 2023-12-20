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
        
        
        private Timer timer = new Timer();
        private Timer timer2 = new Timer();
        private Timer timer3 = new Timer();
        private Random random = new Random();
        private List<Fruit> fruits = new List<Fruit>();
        
        
        public FruitNinjaForm()
        {
            InitializeComponent();
            
        }
        private void FruitNinjaForm_Load(object sender, EventArgs e)
        {

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(4, 15); i++)
            {
                var bombNumber = random.Next(5);

                var fruit = bombNumber == 4 ? new BombFruit(this) :
                            bombNumber == 3 ? new SlowMotionFruit(this) : new Fruit(this);
                
                fruits.Add(fruit);
                fruit.Start();
            }
            timer.Interval = random.Next(2000, 5000);

        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if(fruit.IsMoveable() && fruit.Contains(e.X, e.Y))
                {
                    fruit.Stop();
                    if (fruit is BombFruit)
                    {
                        EndGame();
                        return;
                    }
                    if (fruit is SlowMotionFruit)
                    {

                        timer2.Tick += Timer2_Tick; 
                        timer2.Start();

                    }
                    fruit.Clear();
                    scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            foreach(var fruit in fruits)
            {
                fruit.timer.Interval = 200;
            }
            timer3.Interval = 5000;
            timer3.Tick += Timer3_Tick;
            timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
           foreach( var fruit in fruits)
            {
                fruit.timer.Interval = 20;
            }
           timer2.Stop();
           timer3.Stop();
        }

        private void EndGame()
        {
           timer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
            }
            MessageBox.Show("Игра закончена");
        }
    }
}
