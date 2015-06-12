using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_one
{
        public enum Operator
        {
            add,
            subtract,
            multiply,
            divide,
            none,
        }
    class Equation
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public Operator op;

        public string performAddition(int first_number, int second_number)
        {
            int answer = first_number + second_number;
            string response = Convert.ToString(answer);
            return response;
        }

        public string performSubtraction(int first_number, int second_number)
        {
            int answer = first_number - second_number;
            string response = Convert.ToString(answer);
            return response;
        }

        public string performMultiplication(int first_number, int second_number)
        {
            double product = first_number * second_number;
            string answer = Convert.ToString(product);
            return answer;
        }

        public string performDivision(int first_number, int second_number)
        {
            double quotient = first_number / second_number;
            string answer = Convert.ToString(quotient);
            return answer;
        }

    }
}
