namespace homeworkGuessNumber
{
    public partial class Form1 : Form
    {
        private int[] answer;
        private List<string> result;

        public Form1()
        {
            InitializeComponent();
            Createlist();
        }

        public void Createlist()
        {
            result = new List<string>();
        }

        private void CreateListboxDatasourse()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = result;
        }

        // �}�l�C��
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            answer = CreatAnswer();
        }

        //�ݵ���
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"answer is {answer[0]}{answer[1]}{answer[2]}{answer[3]}");
            button1.Enabled = true;
        }


        //����XA�XB,���G��ܦblistbox
        private void button3_Click(object sender, EventArgs e)
        {
            int correctPosition = 0;
            int correctNumber = 0;

            if (answer == null)
            {
                MessageBox.Show("���I���}�l�C��");
            }
            else
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (answer[i].ToString() == textBox1.Text[i].ToString())
                    {
                        correctPosition += 1;
                    }
                    else if (answer.Contains(int.Parse(textBox1.Text[i].ToString())) & answer[i].ToString() != textBox1.Text[i].ToString())
                    {
                        correctNumber += 1;
                    }
                }
            }
            result.Add($"{textBox1.Text} : {correctPosition}A{correctNumber}B");
            CreateListboxDatasourse();
        }


        //��󭫨�
        private void button4_Click(object sender, EventArgs e)
        {
            Createlist();
            CreateListboxDatasourse();
        }


        //�Ыؤ������H����
        private int[] CreatAnswer()
        {
            Random random = new Random();
            int[] answer = new int[4];

            for (int i = 0; i <= 3; i++)
            {
                answer[i] = random.Next(1, 10);

                for (int j = 0; j < i; j++)
                {
                    if (answer[j] == answer[i])
                    {
                        answer[i] = random.Next(1, 10);
                        j = 0;
                    }
                }
            }
            return answer;
        }


    }
}
