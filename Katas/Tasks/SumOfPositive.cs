using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    static class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}
