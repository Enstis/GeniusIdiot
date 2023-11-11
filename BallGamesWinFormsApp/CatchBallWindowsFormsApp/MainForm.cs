using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchBallWindowsFormsApp
{
    public partial class MainForm : Form
    {
        
        List<Balll> balls;
       
        int countCatchBall = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            StopButton.Enabled = true;
            balls = new List<Balll>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBallRandom(this);
                balls.Add(moveBall);
                moveBall.Start();
            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            clearButton.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                balls[i].Stop();
                if (balls[i].CatchBall()) countCatchBall++;
            }
            MessageBox.Show($"Поймано мячей: {countCatchBall}");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            countCatchBall = 0;
            startButton.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                balls[i].Clear();
            }
        }
    }
}
