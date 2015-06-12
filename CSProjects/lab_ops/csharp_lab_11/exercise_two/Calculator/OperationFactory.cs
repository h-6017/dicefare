using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class OperationFactory
    {
        public Operation new_operation;
        public Operation create_operation(string operation)
        {
            if (operation == "+")
            {
                this.new_operation = new OperationAdd();
            }
            else if (operation == "-")
            {
                this.new_operation = new OperationSubtract();
            }
            else if (operation == "*")
            {
                this.new_operation = new OperationMultiply();
            }
            else if (operation == "/")
            {
                this.new_operation = new OperationDivide();
            }
            return this.new_operation;
        }
    }
}
