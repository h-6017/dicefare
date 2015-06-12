using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_one
{
    class Program
    {
        public Equation equation;
        public Program()
        {
            if (this.equation == null)
            {
                this.equation = new Equation();
            }
        }

        static void Main(string[] args)
        {
            Program self = new Program();
            self.chooseOperator();
            self.chooseNumbers();
            Operator eq_operator = self.equation.op;
            switch (eq_operator)
            {
                case Operator.add:
                    Console.WriteLine(self.equation.performAddition(self.equation.firstNumber, self.equation.secondNumber));
                    break;
                case Operator.subtract:
                    Console.WriteLine(self.equation.performSubtraction(self.equation.firstNumber, self.equation.secondNumber));
                    break;
                case Operator.divide:
                    Console.WriteLine(self.equation.performDivision(self.equation.firstNumber, self.equation.secondNumber));
                    break;
                case Operator.multiply:
                    Console.WriteLine(self.equation.performMultiplication(self.equation.firstNumber, self.equation.secondNumber));
                    break;
            }
            Console.ReadKey();
            
        }

        private void chooseNumbers()
        {
            Console.WriteLine("Please enter the first number in your operation");
            string user_choice_one = Console.ReadLine();
            Console.WriteLine("Please enter the second number in your operation");
            string user_choice_two = Console.ReadLine();
            this.equation.firstNumber = Convert.ToInt32(user_choice_one);
            this.equation.secondNumber = Convert.ToInt32(user_choice_two);

        }
        private void chooseOperator()
        {
            Console.WriteLine("Please decide which operation you would like to perform\n [options]:[+][-][*][/]");
            string user_input = Console.ReadLine();
            if(user_input == "+")
            {
                this.equation.op = Operator.add;
            }
            else if (user_input == "-")
            {
                this.equation.op = Operator.subtract;
            }
            else if (user_input == "*")
            {
                this.equation.op = Operator.multiply;
            }
            else if (user_input == "/")
            {
                this.equation.op = Operator.divide;
            }
        }
    }
}
