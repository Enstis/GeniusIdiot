using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Web;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 10;




        private string Name;
        private User User;
        private int mapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        public static string Path = "2048result.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnterForm enter = new EnterForm();
            enter.ShowDialog();

            
            mapSize = enter.sizeNumber;
            
            var userList = UserResultRepository.GetUserResults();
            bestLabel.Text = userList[^1].Score.ToString();

            User = new User(enter.enterNameTextBox.Text);
            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        private void InitMap()
        {
            ClientSize = new Size(startX + (labelSize + padding) *mapSize, startY + (labelSize + padding) * mapSize);
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
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    string textNumber = "";
                    int number = random.Next(101);
                    if (number > 0 && number <= 25)
                    {
                        textNumber = "4";

                    }
                    else if (number > 25 && number <= 100)
                    {
                        textNumber = "2";
                        
                    }
                    

                    if (textNumber != string.Empty)
                    {
                        labelsMap[indexRow, indexColumn].Text = textNumber;
                        var color = changeColorLabel(labelsMap[indexRow, indexColumn].Text);
                        labelsMap[indexRow, indexColumn].BackColor = color.BackColor;
                        break;
                    }

                    //ðàíäîìíî ãåíåðèðóåì ëèáî 2 ëèáî 4
                }
            }

            
            


        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i,j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool EndGame() 
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private Label changeColorLabel (string numberLableString)
        {
            
            Label labelColor = new Label();
            switch (numberLableString)
            {
                case "": labelColor.BackColor = Color.PeachPuff;
                        break;
                case "2" : labelColor.BackColor = Color.LightSalmon;
                    break;
                case "4": labelColor.BackColor = Color.LightSalmon;
                    break;
                case "8": labelColor.BackColor = Color.DarkSalmon;
                    break;
                case "16": labelColor.BackColor = Color.DarkSalmon;
                    break;
                case "32": labelColor.BackColor = Color.Coral;
                    break;
                case "64": labelColor.BackColor = Color.Coral;
                    break;
                case "128": labelColor.BackColor = Color.Tomato;
                    break;
                case "256": labelColor.BackColor = Color.Tomato;
                    break;
                case "512": labelColor.BackColor = Color.OrangeRed;
                    break;


            }
            return labelColor;
        }


        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.PeachPuff;
            label.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(labelSize, labelSize);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = startX + indexColumn * (labelSize + padding);
            int y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }

            GenerateNumber();
            ShowScore();

            if (Win())
            {
                User.Score = int.Parse(scoreLabel.Text);
                UserResultRepository.Save(User);
                MessageBox.Show("Âû ïîáåäèëè");
            }
            if (EndGame())
            {
                User.Score = int.Parse(scoreLabel.Text);
                UserResultRepository.Save(User);
                MessageBox.Show("Âû ïðîèãðàëè");
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    var color = changeColorLabel(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = color.BackColor;

                                    labelsMap[k, j].Text = string.Empty;
                                    color = changeColorLabel(labelsMap[k, j].Text);
                                    labelsMap[k, j].BackColor = color.BackColor;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                var color = changeColorLabel(labelsMap[i, j].Text);
                                labelsMap[i, j].BackColor = color.BackColor;

                                labelsMap[k, j].Text = string.Empty;
                                color = changeColorLabel(labelsMap[k, j].Text);
                                labelsMap[k, j].BackColor = color.BackColor;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    var color = changeColorLabel(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = color.BackColor;

                                    labelsMap[k, j].Text = string.Empty;
                                    color = changeColorLabel(labelsMap[k, j].Text);
                                    labelsMap[k, j].BackColor = color.BackColor;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                var color = changeColorLabel(labelsMap[i, j].Text);
                                labelsMap[i, j].BackColor = color.BackColor;

                                labelsMap[k, j].Text = string.Empty;
                                color = changeColorLabel(labelsMap[k, j].Text);
                                labelsMap[k, j].BackColor = color.BackColor;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;


                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    var color = changeColorLabel(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = color.BackColor;


                                    labelsMap[i, k].Text = string.Empty;
                                    color = changeColorLabel(labelsMap[i, k].Text);
                                    labelsMap[i, k].BackColor = color.BackColor;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                var color = changeColorLabel(labelsMap[i, j].Text);
                                labelsMap[i, j].BackColor = color.BackColor;

                                labelsMap[i, k].Text = string.Empty;
                                color = changeColorLabel(labelsMap[i, k].Text);
                                labelsMap[i, k].BackColor = color.BackColor;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;


                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    var color = changeColorLabel(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = color.BackColor;

                                    labelsMap[i, k].Text = string.Empty;
                                    color = changeColorLabel(labelsMap[i, k].Text);
                                    labelsMap[i, k].BackColor = color.BackColor;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                var color = changeColorLabel(labelsMap[i, j].Text);
                                labelsMap[i, j].BackColor = color.BackColor;

                                labelsMap[i, k].Text = string.Empty;
                                color = changeColorLabel(labelsMap[i, k].Text);
                                labelsMap[i, k].BackColor = color.BackColor;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ðåñòàðòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserResultRepository.Save(User);
            Application.Restart();

        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ïðàâèëàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesForm rules = new RulesForm();
            rules.ShowDialog();
        }

        private void bestLabel_Click(object sender, EventArgs e)
        {


        }

        private void ðåçóëüòàòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableResultForm tableResult = new TableResultForm();
            tableResult.ShowDialog();
        }
    }
}