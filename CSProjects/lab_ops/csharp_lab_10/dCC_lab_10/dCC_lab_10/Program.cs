using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dCC_lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, if you would like me to calculate\n the number of digits in a particular\n number, simply input the number");
            string input = Console.ReadLine();
            Console.WriteLine("{0} has {1} digit[s].", input, get_digits(input));
            Console.ReadKey();
        }
        static int get_digits(string input)
        {

            List<string> digits = new List<string>();
            foreach (char ch in input)
            {
                digits.Add(ch.ToString());
            }
            int number_of_digits = digits.Count();

            return number_of_digits;

        }
    }
}
