namespace CatchBallWinFormsApp
{
    public partial class MainForm : Form
    {

        List<MoveBallRandom> moveBallsRandom = new List<MoveBallRandom>();
        int countCatchBall = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            StopButton.Enabled = true;
            moveBallsRandom = new List<MoveBallRandom>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBallRandom(this);
                moveBallsRandom.Add(moveBall);
                moveBall.Start();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            clearButton.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                moveBallsRandom[i].Stop();
                if (moveBallsRandom[i].CatchBall(moveBallsRandom[i])) countCatchBall++;
            }
            MessageBox.Show($"Поймано мячей: {countCatchBall}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            countCatchBall = 0;
            startButton.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                moveBallsRandom[i].Clear();
            }
        }
    }
}