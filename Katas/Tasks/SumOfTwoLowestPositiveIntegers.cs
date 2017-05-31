using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    static class SumOfTwoLowestPositiveIntegers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers.Take(2).Sum();
        }
    }
}
