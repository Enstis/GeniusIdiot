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
            var graphics = CreateGraphics();
            var brush = Brushes.Aqua;

            var rectangle = new Rectangle(150, 150, 100, 100);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}