 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    static class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int result = 0;
            double j = Math.Pow(2, BinaryArray.Length - 1);
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                if (BinaryArray[i] == 1)
                    result += (int)j;
                j /= 2;
            }
            return result;
        }
    }
}
