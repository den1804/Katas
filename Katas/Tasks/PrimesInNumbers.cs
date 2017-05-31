using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    class PrimesInNumbers
    {
        public static String factors(int lst)
        {
            string result = "";
            int count = 0;
            for (int i = 2; i < lst; i++)
            {
                while (lst % i == 0)
                {
                    count++;
                    lst /= i;
                }
                if (count == 0)
                    continue;
                if (count > 1)
                    result += "("+ i + "**" + count + ")";
                else if (count == 1)
                    result += "("+ i + ")";
                count = 0;
            }
            return result;
        }
    }
}
