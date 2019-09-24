using System.Collections.Generic;
namespace Program
{
    public static class Operation
    {
        public static double Add(IEnumerable<double> numbers)
        {
            double sum = 0.0;
            foreach(var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}