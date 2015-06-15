using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_3
{
    class UserInterface
    {
        private Equation equation;
        private bool is_running;
        public UserInterface()
        {
            this.is_running = true;

            if (this.equation == null)
            {
                this.equation = new Equation();
            }
        }
        public void start()
        {
            while (this.is_running)
            {
                Equation eq = this.equation;
                List<string> operands = operand_prompt();
                eq.first_operand = operands[0];
                eq.second_operand = operands[1];
                eq.math_symbol = this.operator_prompt();
                Console.WriteLine("The answer is : ", eq.Compute());
                Console.WriteLine("Continue?[y/n]");
                string user_input = Console.ReadLine();
                if (user_input == "y")
                {
                    this.is_running = false;
                }
            }
        }

        private List<string> operand_prompt()
        {
            List<string> operands = new List<string>();
            Console.WriteLine("Please enter the first number in the equation.");
            string first_operand = Console.ReadLine();
            Console.WriteLine("Please enter the second number in the equation.");
            string second_operand = Console.ReadLine();
            operands.Add(first_operand);
            operands.Add(second_operand);
            return operands;
        }
        public string operator_prompt()
        {
            Console.WriteLine("Please enter the operation you would like to perform");
            Console.WriteLine("Addition       : [+]");
            Console.WriteLine("Subtraction    : [-]");
            Console.WriteLine("Division       : [/]");
            Console.WriteLine("Multiplication : [*]");
            string desired_operation = Console.ReadLine();
            return desired_operation;
        }
        public Equation createNewEquation(string math_symbol, string first_operand, string second_operand)
        {
            Equation equation = new Equation(math_symbol, first_operand, second_operand);
            return equation;
        }
    }
}
