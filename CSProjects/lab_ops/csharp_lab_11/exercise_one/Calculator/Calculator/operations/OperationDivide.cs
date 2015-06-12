using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationDivide: Operation
    {
        public override double compute(double first_number, double second_number)
        {
            return first_number / second_number;
        }
    }
}
