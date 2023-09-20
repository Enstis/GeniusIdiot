namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            var randomNumberLabel = random.Next(mapSize * mapSize);
            var indexRow = randomNumberLabel / mapSize;
            var indexColumn = randomNumberLabel % mapSize;
            if (labelsMap[indexRow, indexColumn].Text == string.Empty)
            {
                labelsMap[indexRow, indexColumn].Text = "2"; //�������� ���������� ���� 2 ���� 4
            }
            else GenerateNumber();
        }


        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.PeachPuff;
            label.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(70, 70);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1;  j >= 0;  j--)
                    {
                        if (labelsMap[i,j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i,k].Text != string.Empty)
                                {
                                    if(labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("����� �������");
            }
            if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("������ �������");
            }
            if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("������� �������");
            }
        }
    }
}