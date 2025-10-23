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

        // 建立資料、初始時間、星座日期
        private async void Form1_Load(object sender, EventArgs e)
        {
            myData = await CreateMyData();
            dateTimePicker1.Value = DateTime.Now;
            stars = CreateStars();
        }

        // 儲存日期更改至對應變數
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
        }

        // 建立星座日期
        private List<StarsDate> CreateStars()
        {
            return new List<StarsDate>()
            {
                new StarsDate() { startDay = 321, endDay = 419 }, //牡羊座
                new StarsDate() { startDay = 420, endDay = 520 }, //金牛座
                new StarsDate() { startDay = 521, endDay = 620 }, //雙子座
                new StarsDate() { startDay = 621, endDay = 722 }, //巨蟹座
                new StarsDate() { startDay = 723, endDay = 822 }, //獅子座
                new StarsDate() { startDay = 823, endDay = 922 }, //處女座
                new StarsDate() { startDay = 923, endDay = 1022 }, //天秤座
                new StarsDate() { startDay = 1023, endDay = 1121 }, //天蠍座
                new StarsDate() { startDay = 1122, endDay = 1221 }, //射手座
                new StarsDate() { startDay = 1222, endDay = 119 }, //摩羯座
                new StarsDate() { startDay = 120, endDay = 218 }, //水瓶座
                new StarsDate() { startDay = 219, endDay = 320 }, //雙魚座
            };
        }

        // 匯入生命靈數資料
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

        //確認使用者星座
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

        // 計算使用者生命靈數
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

        // 分析結果
        private void button1_Click(object sender, EventArgs e)
        {
            int myStar = CheckMyStar();
            string myLifeNumber = CountLifeNumber();

            label3.Text = $"你的星座是：{myData[myStar * 10]}\n\n{myData[myStar * 10 + int.Parse(myLifeNumber)]}";
        }
    }
}
