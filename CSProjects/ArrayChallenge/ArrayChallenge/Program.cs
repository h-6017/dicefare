using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me how wide this array should be.");
            string width = Console.ReadLine();
            Console.WriteLine("Please tell me how long this array should be.");
            string length = Console.ReadLine();
            genArray(width, length);
            Console.WriteLine("Generating 2d array {0} untis wide and {1} units long.", width, length);
        }

        private static void genArray(string width, string length)
        {
            int arr_width = int.Parse(width);
            int arr_length = int.Parse(length);
            int[,] arr = new int[arr_width, arr_length];
            int bound_zero = arr.GetUpperBound(0);
            int bound_one = arr.GetUpperBound(1);
            bool duplicate = true;
            Random random = new Random();
            for (int i = 0; i <= bound_zero; i++)
            {
                for (int j = 0; j <= bound_one; j++)
                {
                    while (duplicate)
                    {
                        int next_element = random.Next(0, bound_one);
                        //arr[i, j] = random.Next(0, bound_one);
                        if 
                        Console.WriteLine(arr[i, j].ToString() + " ");
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
