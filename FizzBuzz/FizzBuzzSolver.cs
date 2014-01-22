using System;

namespace FizzBuzz
{
    public class FizzBuzzSolver : IFizzBuzzSolver
    {
        public string Solve(int numberToPrint)
        {
            if (numberToPrint >= FizzBuzzMap.Result.Length)
            {
                return "number is to large";
            }

            return FizzBuzzMap.Result[Math.Abs(numberToPrint)];
        }
    }
}
