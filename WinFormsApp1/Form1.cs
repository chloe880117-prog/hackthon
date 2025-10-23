using System.ComponentModel;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int year;
        private int month;
        private int day;
        private List<string> myData;
        private List<StarsDate> stars;
        public Form1()
        {
            InitializeComponent();
        }

        // �إ߸�ơB��l�ɶ��B�P�y���
        private async void Form1_Load(object sender, EventArgs e)
        {
            myData = await CreateMyData();
            dateTimePicker1.Value = DateTime.Now;
            stars = CreateStars();
        }

        // �x�s������ܹ����ܼ�
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
        }

        // �إ߬P�y���
        private List<StarsDate> CreateStars()
        {
            return new List<StarsDate>()
            {
                new StarsDate() { startDay = 321, endDay = 419 }, //�d�Ϯy
                new StarsDate() { startDay = 420, endDay = 520 }, //�����y
                new StarsDate() { startDay = 521, endDay = 620 }, //���l�y
                new StarsDate() { startDay = 621, endDay = 722 }, //���ɮy
                new StarsDate() { startDay = 723, endDay = 822 }, //��l�y
                new StarsDate() { startDay = 823, endDay = 922 }, //�B�k�y
                new StarsDate() { startDay = 923, endDay = 1022 }, //�ѯ��y
                new StarsDate() { startDay = 1023, endDay = 1121 }, //���Ȯy
                new StarsDate() { startDay = 1122, endDay = 1221 }, //�g��y
                new StarsDate() { startDay = 1222, endDay = 119 }, //���~�y
                new StarsDate() { startDay = 120, endDay = 218 }, //���~�y
                new StarsDate() { startDay = 219, endDay = 320 }, //�����y
            };
        }

        // �פJ�ͩR�F�Ƹ��
        public async Task<List<string>> CreateMyData()
        {
            string fileName = "�ͩR�F��.txt";

            if (File.Exists(fileName))
            {
                return await File.ReadLinesAsync(fileName)
                    .Select(x => x.Replace("�@", ""))
                    .Where(x => !string.IsNullOrEmpty(x))
                    .ToListAsync();
            }
            return null;
        }

        //�T�{�ϥΪ̬P�y
        private int CheckMyStar()
        {
            int starNumber = month*100 + day;

            if (month == 1 && day <= 19 || month == 12 && day >= 22)
            {
                return 9;
            }
            var myStar = stars.FirstOrDefault((x) => x.startDay <= starNumber && starNumber <= x.endDay,new StarsDate { endDay = 0,startDay = 0});

            return stars.IndexOf(myStar);
        }

        // �p��ϥΪ̥ͩR�F��
        public string CountLifeNumber()
        {
            string lifenumber = year.ToString() + month.ToString() + day.ToString();

            while (lifenumber.Length > 1)
            {
                int number = 0;
                for (int i = 0; i <= lifenumber.Length - 1; i++)
                {

                    number += int.Parse(lifenumber[i].ToString());
                }
                lifenumber = number.ToString();
                number = 0;
            }

            return lifenumber;
        }

        // ���R���G
        private void button1_Click(object sender, EventArgs e)
        {
            int myStar = CheckMyStar();
            string myLifeNumber = CountLifeNumber();

            label3.Text = $"�A���P�y�O�G{myData[myStar * 10]}\n\n{myData[myStar * 10 + int.Parse(myLifeNumber)]}";
        }
    }
}
