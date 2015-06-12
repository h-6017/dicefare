using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dCC_lab_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            printOutput(getNumberOfCharacters(args));
            Console.ReadKey();
        }
        static List<object> getNumberOfCharacters(string[] arguments)
        {
            List<object> data = new List<object>();
            string argument = arguments[0];
            int char_num = argument.Count();
            data.Add(argument);
            data.Add(char_num);
            return data;
        }
        static void printOutput(List<object> data)
        {
            string argument = Convert.ToString(data[0]);
            int number_of_prints = Convert.ToUInt16(data[1]);
            Console.WriteLine(String.Concat(Enumerable.Repeat((argument + " "), number_of_prints)));

        }
    }

}
