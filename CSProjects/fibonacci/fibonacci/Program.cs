using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A number to begin Calculation");
            string string_input = Console.ReadLine();
            Console.WriteLine("Please Enter the amount of terms you'd like.");
            string string_input_terms_desired = Console.ReadLine();
            int termsDesired = int.Parse(string_input_terms_desired);
            int initialNumber = int.Parse(string_input); 

            for (int i = 0;i < termsDesired ;i++ )
            {
                Console.WriteLine(fibo(initialNumber, initialNumber));
            }
            Console.ReadKey();

        }

        private static int fibo(int currentNumber, int shift = 0)
        {
            
            if (currentNumber <= shift)
            {
                return currentNumber;
            }
            else
            {
                return(fibo(currentNumber - 1) + fibo(currentNumber - 2));
            }
            /*Console.WriteLine("{0}", currentNumber );
            int nextNumber = previousNumber + currentNumber;
            if (nextNumber < 7000)
            {
                int newCurrentNumber = nextNumber;
                fibo(currentNumber, newCurrentNumber);
            }
            */
        }
    }
}
