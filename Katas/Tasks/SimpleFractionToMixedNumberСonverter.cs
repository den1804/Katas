using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    class SimpleFractionToMixedNumberСonverter
    {
        public static string MixedFraction(string s)
        {
            string[] arrayString = s.Split('/');
            int a = Convert.ToInt32(arrayString[0]);
            int b = Convert.ToInt32(arrayString[1]);
            if (a > 0 && b < 0)
            {
                a = -a;
                b = -b;
            }
            int derivision = a / b;
            s = "";
            if (a % b == 0)
                return derivision.ToString();
            int remainDerivision = a % b;
            if (derivision != 0)
                s = derivision.ToString() + " ";
            for (int i = Math.Abs(b); i > 1; i--)
            {
                if (remainDerivision % i == 0 && b % i == 0)
                {
                    remainDerivision /= i;
                    b /= i;
                }
            }
            if (derivision < 0 || (remainDerivision < 0 && b < 0))
                return s + Math.Abs(remainDerivision).ToString() + '/' + Math.Abs(b).ToString();
            return s + remainDerivision.ToString() + '/' + b.ToString();
        }
    }
}
