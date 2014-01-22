using System;

namespace FizzBuzz
{
    public class DivisionMatcher : IComparable<DivisionMatcher>
    {
        private readonly int _divisor;
        private readonly string _result;

        public DivisionMatcher(int divisor, string result)
        {
            _divisor = divisor;
            _result = result;
        }

        public string Result
        {
            get { return _result; }
        }

        public bool Match(int number)
        {
            return (number % _divisor) == 0;
        }

        public int CompareTo(DivisionMatcher other)
        {
            return other._divisor.CompareTo(_divisor);
        }
    }
}