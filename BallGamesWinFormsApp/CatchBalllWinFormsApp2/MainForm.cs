using CatchBallWinFormsApp;

namespace CatchBalllWinFormsApp2
{
    public partial class MainForm : Form
    {
        List<MoveBallRandom> moveBallsRandom = new List<MoveBallRandom>();
        private int countBalls = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            clearButton.Enabled = true;
            startButton.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBallRandom(this);
                moveBallsRandom.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }
       
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBallsRandom != null)
            {
                foreach (var ball in moveBallsRandom)
                {
                    if (ball.IsMoveable() && ball.Contains(e.X, e.Y))
                    {
                        ball.Stop();
                        countBalls++;
                    }
                }
                countBallsLabel.Text = countBalls.ToString();
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}