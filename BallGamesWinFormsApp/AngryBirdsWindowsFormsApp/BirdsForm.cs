using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public partial class BirdsForm : Form
    {
        BirdBall birdBall;
        PigBall pigBall;
        Timer timer = new Timer();
        public BirdsForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(birdBall.Intersect(pigBall))
            {
                CreateNewBird();
                CreateNewPig();

            }
            if(!birdBall.IsMoveable() || birdBall.IsOutSide())
            {
                CreateNewBird();
            }
        }

        public void CreateNewBird()
        {
            timer.Stop();
            if (birdBall != null)
            {
                birdBall.Stop();
                birdBall.Clear();
            }
            birdBall = new BirdBall(this);
            birdBall.Show();
        }



        private void BirdsForm_Load(object sender, EventArgs e)
        {
            //birdBall = new BirdBall(this);
            pigBall = new PigBall(this);

        }

        private void BirdsForm_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Start();
           birdBall.DeterminationSpeed(e.X, e.Y);
           birdBall.Start();

        }

        private void BirdsForm_Shown(object sender, EventArgs e)
        {
            CreateNewBird();
            CreateNewPig();
        }

        private void CreateNewPig()
        {
            if (pigBall != null)
            {
                pigBall.Clear();
            }
            pigBall = new PigBall(this);
            pigBall.Show();
         }
    }
}
