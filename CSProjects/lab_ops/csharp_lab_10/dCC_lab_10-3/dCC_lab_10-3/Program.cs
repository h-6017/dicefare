
namespace dCC_lab_10_3
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; using System.Threading.Tasks;

    class Program
    {
        private static string odd_word;
        private static int middle = 0;
        private static string first_part;
        private static string second_part;

        static void Main(string[] args)
        {
            Console.WriteLine("Number of command line parameters = {0}", args.Length);

            if (args.Count() % 2 != 0)
            {
                int odd_number = (args.Length /2);
                string odd_word = args[odd_number];
                middle = odd_word.Length / 2;
                first_part = odd_word.Substring(0, middle);
                second_part = odd_word.Substring(middle);

                

            }

            int total_args = args.Length;
            int half_args = total_args / 2;

            int second_half = total_args - half_args;

            List<string> arguments_first_half = new List<string>();
            List<string> arguments_second_half = new List<string>();

            //Console.WriteLine(second_half);
            for (int i = 0; i < (total_args / 2); i++ )
            {
                arguments_first_half.Add(args[i]);
            }
            arguments_first_half.Add(first_part);

            arguments_second_half.Add(second_part);
            for (int i = second_half; i < total_args; i++)
            {
                arguments_second_half.Add(args[i]);
            }
            
            for (int i = 0; i < arguments_first_half.Count; i++)
            {
                Console.Write(arguments_first_half[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < arguments_second_half.Count; i++)
            {
                Console.Write(arguments_second_half[i] + " ");
            }

                Console.ReadKey();
        }

    }

}
