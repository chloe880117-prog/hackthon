using System.ComponentModel;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int year;
        private int month;
        private int day;
        private string star;
        private DateTimePicker dateTimePicker;
        private List<string> myData;
        public Form1()
        {
            InitializeComponent();

        }


        // �إ߸�ƻP��l�ɶ�
        private async void Form1_Load(object sender, EventArgs e)
        {
            myData = await CreateMyData();
            dateTimePicker1.Value = DateTime.Now;
        }


        // ���R���G
        private void button1_Click(object sender, EventArgs e)
        {

            int myStar = CheckStar();
            string myLifeNumber = CountLifeNumber();

            //MessageBox.Show(string.Join("\n", myData.Select((v, i) => $"{i}: {v}")));

            label3.Text = $"�A���P�y�O�G{myData[myStar*10]}\n\n{myData[myStar*10+int.Parse(myLifeNumber)]}";


        }


        // �x�s������ܹ����ܼ�
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
        }


        // �إ߬P�y
        private int CheckStar()
        {
            if (month == 1 && day <= 19 || month == 12 && day >= 22)
            {
                star = "���~�y";
                return 9;
            }
            else if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                star = "���~�y";
                return 10;
            }
            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                star = "�����y";
                return 11;
            }
            else if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {
                star = "�d�Ϯy";
                return 0;
            }
            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {
                star = "�����y";
                return 1;
            }
            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {
                star = "���l�y";
                return 2;
            }
            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {
                star = "���ɮy";
                return 3;
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                star = "��l�y";
                return 4;
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                star = "�B�k�y";
                return 5;
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                star = "�ѯ��y";
                return 6;
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {
                star = "���Ȯy";
                return 7;
            }
            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {
                star = "�g��y";
                return 8;
            }
            return 0;
        }


        // �פJ�ɮ�
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


        // �p��ͩR�F��
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


    }
}
