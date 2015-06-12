using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum ImpossibleCalculation
    {
        DivideByZero,
        ExceededMaxValue,
        NotANumber
    }
    public class Operation
    {
        //Fields
        private double first_number;
        private double second_number;
        private string chosen_operator;
        private ImpossibleCalculation imp_calc;
        public Operation(string chosen_operator, double first_number, double second_number)
        {
            this.first_number = first_number;
            this.second_number = second_number;
            this.chosen_operator = chosen_operator;
            this.validateOperation(this.chosen_operator, this.first_number, this.second_number);
        }

        private void validateOperation(string chosen_operator, double first_number, double second_number)
        {
            this.imp_calc = ImpossibleCalculation.DivideByZero;
        }
        public abstract double compute(double first_operand, double second_operand);

    }
}
