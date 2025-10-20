namespace hackthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入大於90的整數：");
            int input = int.Parse(Console.ReadLine());

            for (int num = 1; num <= input; num++)
            {
                if (num % 15 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
