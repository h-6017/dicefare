using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dCC_lab_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings!\nKindy enter your name!");
            string input_first_name = Console.ReadLine();
            Console.WriteLine("... And your last name");
            string input_last_name = Console.ReadLine();
            Console.WriteLine("... And Lastly your favorite color.");
            string input_favorite_color = Console.ReadLine();
            string output = String.Format("{0} is the favorite color of: {1}, {2}.", input_favorite_color, input_last_name, input_first_name );
            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
