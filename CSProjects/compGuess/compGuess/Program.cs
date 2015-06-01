using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace compGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int waitTime = new Int32();
            int _Max = 5000;
            int _startFloor = 1;
            int ceiling = new Int32();
            int floor = new Int32();
            Random rnd = new Random();
            bool guessing = true;
            Console.WriteLine("Enter the number you wish me to guess. Must fall between 1 and 5000");
            string inputString = Console.ReadLine();
            int userInput = int.Parse(inputString);
            ceiling = _Max;
            floor = _startFloor;
            waitTime = 0;
            sw.Start();
            while (guessing)
            {
                Console.WriteLine("Guessing at {0}",sw.ElapsedMilliseconds);
                int computerGuess = guess(floor, ceiling, rnd);
                if (computerGuess < userInput)
                {
                    floor = computerGuess;
                    Console.WriteLine("Apparently {0} is too low.", computerGuess);
                    waitTime = waitTime + 1;
                    guessing = true;
                }
                else if (computerGuess > userInput)
                {
                    ceiling = computerGuess;
                    Console.WriteLine("Apparently {0} is too High.", computerGuess);
                    waitTime = waitTime + 1;
                    guessing = true;
                }
                else if (computerGuess == userInput)
                {
                    Console.WriteLine("I did it!");
                    guessing = false;
                }
                wait(waitTime);
            }
            Console.WriteLine("End Time {0}", sw.ElapsedMilliseconds);

        }
        static int guess(int floor, int ceiling, Random number)
        {
            double newGuess = Math.Floor((Convert.ToDouble(floor) + Convert.ToDouble(ceiling))/2);
            int compGuess = Convert.ToInt32(newGuess);
            return compGuess;         
        }

        static void wait(int waitTime)
        {
            System.Threading.Thread.Sleep((int)Math.Pow(waitTime, 2) * 1000);
        }
    }
}
