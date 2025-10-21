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


        // 建立資料與初始時間
        private async void Form1_Load(object sender, EventArgs e)
        {
            myData = await CreateMyData();
            dateTimePicker1.Value = DateTime.Now;
        }


        // 分析結果
        private void button1_Click(object sender, EventArgs e)
        {

            int myStar = CheckStar();
            string myLifeNumber = CountLifeNumber();

            //MessageBox.Show(string.Join("\n", myData.Select((v, i) => $"{i}: {v}")));

            label3.Text = $"你的星座是：{myData[myStar*10]}\n\n{myData[myStar*10+int.Parse(myLifeNumber)]}";


        }


        // 儲存日期更改至對應變數
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
        }


        // 建立星座
        private int CheckStar()
        {
            if (month == 1 && day <= 19 || month == 12 && day >= 22)
            {
                star = "摩羯座";
                return 9;
            }
            else if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                star = "水瓶座";
                return 10;
            }
            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                star = "雙魚座";
                return 11;
            }
            else if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {
                star = "牡羊座";
                return 0;
            }
            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {
                star = "金牛座";
                return 1;
            }
            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {
                star = "雙子座";
                return 2;
            }
            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {
                star = "巨蟹座";
                return 3;
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                star = "獅子座";
                return 4;
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                star = "處女座";
                return 5;
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                star = "天秤座";
                return 6;
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {
                star = "天蠍座";
                return 7;
            }
            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {
                star = "射手座";
                return 8;
            }
            return 0;
        }


        // 匯入檔案
        public async Task<List<string>> CreateMyData()
        {
            string fileName = "生命靈數.txt";

            if (File.Exists(fileName))
            {
                return await File.ReadLinesAsync(fileName)
                    .Select(x => x.Replace("　", ""))
                    .Where(x => !string.IsNullOrEmpty(x))
                    .ToListAsync();
            }
            return null;
        }


        // 計算生命靈數
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
