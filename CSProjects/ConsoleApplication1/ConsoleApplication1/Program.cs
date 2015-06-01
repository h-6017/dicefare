using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitTime = new Int16();
            List<int> guessList = new List<int>();
            Random rndNum = new Random();
            bool numberGuessed = false;
            Console.WriteLine("Hello, My name Is Querdy! And I am going to attempt to guess the number you pick, I promis I won't Look!\n");
            Console.WriteLine("First things first! Pick a number from 1 - 5000\n :>:");
            string inputString = Console.ReadLine();
            int playerChoice = int.Parse(inputString);
            Console.WriteLine("The number you picked is: {0}", playerChoice);
            waitTime = 1;
            while (numberGuessed == false) 
            {
                int compChoice = guess(calcGuessRange(guessList, playerChoice), rndNum);
                guessList.Add(compChoice);
                if (compChoice == playerChoice)
                {
                    Console.WriteLine("And that Is Correct! I guessed {0}, and you picked {1}!", compChoice, playerChoice);
                    numberGuessed = true;
                }
                else
                {
                    
                    Console.WriteLine("{0} was the wrong guess I take it? Recalculating...", compChoice);
                    wait(getNewWaitTime(waitTime));
                    numberGuessed = false;
                }
            }
            Console.ReadKey();
        }
        static List<int> calcGuessRange(List<int> guessList, int playerChoice)
        {
            List<int> guessParams = new List<int>();
            var max = guessList.Max();
            var min = guessList.Min();
            if (max < playerChoice && min < playerChoice)
            {
                guessParams.Add(max);
                guessParams.Add(5000);
                return guessParams;
            }
            else if (min > playerChoice && max > playerChoice)
            {
                guessParams.Add(5000);
                guessParams.Add(min);
                return guessParams;
            }
            else if (max > playerChoice && min < playerChoice)
            {
                guessParams.Add(min);
                guessParams.Add(max);
                return guessParams;
            }
            else
            {
                guessParams.Add(0);
                guessParams.Add(5000);
                return guessParams;

            }
        }
        static int guess(List<int> guessParams, Random rndNum)
        {
            int compChoice = rndNum.Next(guessParams[0], guessParams[1]);
            Console.WriteLine("The number I picked is: {0}", compChoice);
            return compChoice;
        }
        static void wait(int waitTime)
        {
            System.Threading.Thread.Sleep(waitTime*1000);
        }
        static int getNewWaitTime(int waitTime)
        {
            double newWaitTime = Math.Pow(waitTime, 2);
            waitTime = Convert.ToInt32(newWaitTime);
            return waitTime;

        }
    }
}
