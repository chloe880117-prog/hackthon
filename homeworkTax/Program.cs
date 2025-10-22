using homework006Tax;
using System.Reflection.Emit;

namespace homeworkTax
{
    internal class Program
    {
        private static decimal input;
        private  static List<Tax> taxList;
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的年收入：");
            input = decimal.Parse(Console.ReadLine());
            taxList = CreateLevelList();

            var myTax = taxList.FirstOrDefault((x) => x.minTax <= input && x.maxTax >= input
            , new Tax { minTax = 0, maxTax = 0, taxRate = 0 });

            decimal result = CountTax(myTax.minTax,myTax.maxTax,myTax.taxRate,myTax.taxLevel);
            Console.WriteLine(result);
        }

        static decimal CountTax(decimal minTax, decimal maxTax, decimal taxRate, int taxLevel)
        {
            decimal taxMoney = 0m;
            decimal fixedTax = 0m;

            for (int level = 0; level < taxLevel; level++)
            {
                fixedTax += taxList[level].taxRate * ((taxList[level].maxTax + 1m - taxList[level].minTax));
            }

            taxMoney = taxRate * (input - minTax + 1) + fixedTax;

            return taxMoney;
        }
        static List<Tax> CreateLevelList()
        {
            return new List<Tax>()
            {
                new Tax{minTax = 1m,maxTax = 540000m,taxRate = 0.05m,taxLevel = 0},
                new Tax{minTax = 540001m,maxTax = 1210000m,taxRate = 0.12m,taxLevel = 1},
                new Tax{minTax =1210001m,maxTax = 2420000m,taxRate = 0.20m,taxLevel = 2},
                new Tax{minTax = 2420001m,maxTax = 4530000m,taxRate = 0.30m,taxLevel = 3},
                new Tax{minTax =4530001m,maxTax = 10310000m,taxRate =0.40m,taxLevel = 4},
                new Tax{minTax = 10310001m,maxTax = decimal.MaxValue,taxRate =0.50m,taxLevel = 5},
            };
        }

    }
}
