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
            this.second_operand = s_op;
        }
        public double Compute()
        {
            this.imp_calc = evaluateOperation(this.math_symbol, this.first_operand, this.second_operand);

            if (this.imp_calc == ImpossibleCalculations.none)
            {
                double f_op = Double.Parse(this.first_operand);
                double s_op = Double.Parse(this.second_operand);
                if (this.math_symbol == "+")
                {
                    return this.Add(f_op, s_op);
                }
                else if (this.math_symbol == "/")
                {
                    return this.Divide(f_op, s_op);
                }
                else if(this.math_symbol == "*")
                {
                    return this.Multiply(f_op, s_op);
                }
                else if (this.math_symbol == "-")
                {
                    return this.Subtract(f_op, s_op);
                }

            }
            Console.WriteLine("This calculation is impossible... \nReason:[{0}]", this.imp_calc.ToString());
            return 0;
        }

        private ImpossibleCalculations evaluateOperation(string math_symbol, string first_operator, string second_operator)
        {

            try
            {
                Double.Parse(first_operand);
                Double.Parse(second_operand);
            }
            catch (Exception exception)
            {
                return ImpossibleCalculations.NotANumber;
            }


            if (math_symbol == "/" && second_operand == "0")
            {
                return ImpossibleCalculations.DivideByZero;
            }
            try 
            {
                double test_one = Convert.ToDouble(first_operand);
                double test_two = Convert.ToDouble(second_operand);
                if (test_one > int.MaxValue || test_two > int.MaxValue)
                {
                    return ImpossibleCalculations.ExceededMaxValue;
                }
            }
            catch(OverflowException)
            {
                return ImpossibleCalculations.ExceededMaxValue;
            }

            return ImpossibleCalculations.none;

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
            return Math.Floor(f_op / s_op);
        }
    }
}
