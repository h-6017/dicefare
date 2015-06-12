using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_3
{
    enum ImpossibleCalculations
    {
        DivideByZero,
        ExceededMaxValue,
        NotANumber,
        none
    }

    class Equation
    {
        public ImpossibleCalculations imp_calc;
        public string math_symbol;
        public string first_operand;
        public string second_operand;
        public Equation()
        {
            this.math_symbol = "+";
            this.first_operand = "2";
            this.second_operand = "2";
        }
        public Equation(string symbol, string f_op, string s_op)
        {
            this.math_symbol = symbol;
            this.first_operand = f_op;
            this.second_operand = f_op;
        }
        public double Compute()
        {
            this.imp_calc = evaluateOperation(this.math_symbol, this.first_operand, this.second_operand);

            if (this.math_symbol == "+")
            {
                return this.Add(this.first_operand, this.second_operand);
            }
            throw new NotImplementedException();
        }

        private ImpossibleCalculations evaluateOperation(string math_symbol, string first_operator, string second_operator)
        {
            ImpossibleCalculations imp_calc = ImpossibleCalculations.none;
            

            bool type_one = first_operand;
            var type_two = second_operand.GetType();
            if (math_symbol == "/" && second_operand == 0)
            {
                imp_calc = ImpossibleCalculations.DivideByZero;
            }
            else if (first_operand > Double.MaxValue || second_operand > Double.MaxValue)
            {
                imp_calc = ImpossibleCalculations.ExceededMaxValue;
            }else if(type_one )
            throw new NotImplementedException();
        }
        public double Add(double f_op, double s_op)
        {
            return f_op + s_op;
        }
        public double Subtract(double f_op, double s_op)
        {
            return f_op - s_op;
        }
        public double Multiply(double f_op, double s_op)
        {
            return f_op * s_op;
        }
        public double Divide(double f_op, double s_op)
        {
            return f_op / s_op;
        }
    }
}
