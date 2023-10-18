namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void printBallButton_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
        }

        private void printRandomButton_Click(object sender, EventArgs e)
        {
            var randomPointBall = new RandomPointBall(this);
        }
    }
}