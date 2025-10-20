using System.Threading.Channels;

namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個有意義的英文敘述字串，例如 'To be or not to be'");

            string[] input = Console.ReadLine().ToLower().Split(' ');

            var dictionary = new Dictionary<string, int>();


            foreach (var str in input)
            {
                if (dictionary.ContainsKey(str))
                {
                    dictionary[str] += 1;
                }
                else
                {
                    dictionary[str] = 1;
                }
                
            }

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key}:{dictionary[key]}");
            }

        }

    }
}
