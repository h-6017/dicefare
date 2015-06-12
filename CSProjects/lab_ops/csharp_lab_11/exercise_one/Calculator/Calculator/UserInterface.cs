using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UserInterface
    {
        private OperationFactory op_factory;
        public UserInterface()
        {
            if (this.op_factory == null)
            {
                this.op_factory = new OperationFactory();
            }
        }
        public void start()
        {
            string chosen_operator = this.operator_prompt();
            Operation new_operation = this.op_factory.create_operation(chosen_operator);
            List<double> operands = this.operand_prompt();
            Console.WriteLine("The answer is : {0}", new_operation.compute(operands[0], operands[1]));
            Console.ReadKey();

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
        public List<double> operand_prompt()
        {
            List<double> operand_list = new List<double>();
            Console.WriteLine("Please enter the first number in the equation");
            string first_operand = Console.ReadLine();
            Console.WriteLine("Please enter the second number in the equation");
            string second_operand = Console.ReadLine();
            operand_list.Add(Double.Parse(first_operand));
            operand_list.Add(Double.Parse(second_operand));
            return operand_list;

        }
    }
}
