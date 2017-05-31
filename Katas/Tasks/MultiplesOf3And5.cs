using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    class MultiplesOf3And5
    {
        public static int Solution(int value)
        {
            int sum = 0;
            if (value < 3)
                return sum;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0)
                    sum += i;
                else if (i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
