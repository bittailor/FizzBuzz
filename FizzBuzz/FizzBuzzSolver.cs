using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz
{
    public class FizzBuzzSolver : IFizzBuzzSolver
    {
        private readonly List<DivisionMatcher> _matchers;

        public FizzBuzzSolver()
        {
            _matchers = new List<DivisionMatcher>
            {
                new DivisionMatcher(3, "Fizz"),
                new DivisionMatcher(5, "Buzz"),
                new DivisionMatcher(15, "FizzBuzz")
            };
            _matchers.Sort();
        }

        public string Solve(int numberToPrint)
        {
            foreach (DivisionMatcher matcher in _matchers)
            {
                if (matcher.Match(numberToPrint))
                {
                    return matcher.Result;
                }
            }
            return numberToPrint.ToString(CultureInfo.InvariantCulture);
        }
    }
}
