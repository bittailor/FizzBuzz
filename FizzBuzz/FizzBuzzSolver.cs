using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzSolver : FizzBuzz.IFizzBuzzSolver
    {
        public string Solve(int numberToPrint)
        {
            string result = "";
            if (numberToPrint % 3 == 0)
            {
                result = result + "Fizz";
            }
            if (numberToPrint % 5 == 0)
            {
                result = result + "Buzz";
            }

            if (String.IsNullOrEmpty(result))
            {
                return numberToPrint.ToString();

            }
            return result;

        }
    }
}
