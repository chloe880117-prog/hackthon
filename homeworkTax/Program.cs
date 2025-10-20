namespace homeworkTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的年收入：");
            decimal input = decimal.Parse(Console.ReadLine());
            decimal tax1 = (decimal)(540000 * 0.05);
            decimal tax2 = (decimal)((1210001 - 540001) * 0.12);
            decimal tax3 = (decimal)((2420001 - 1210001) * 0.20);
            decimal tax4 = (decimal)((4530001 - 2420001) * 0.30);
            decimal tax5 = (decimal)((10310001 - 4530001) * 0.40);

            decimal result = 0;
            if (input <= 540000)
            {
                result = input * (decimal)0.05;
            }
            else if (540001 <= input & input <= 1210000)
            {
                result = ((input - 540000) * (decimal)0.12) + tax1;
            }
            else if (1210001 <= input & input <= 2420000)
            {
                result = ((input - 1210000)*(decimal)0.20) + tax1 + tax2;
            }
            else if (2420001 <= input & input <= 4530000)
            {
                result = ((input -2420000)*(decimal)0.30)+tax1+tax2+tax3;
            }
            else if (4530001 <= input & input <= 10310000)
            {
                result = ((input-4530000)*(decimal)0.40)+tax1+tax2+tax3+tax4;
            }
            else if (input >= 10310001)
            {
                result = ((input-10310000)*(decimal)0.50)+tax1+tax2+tax3+tax4+tax5;
            }
            Console.WriteLine(result);
        }
    }
}
