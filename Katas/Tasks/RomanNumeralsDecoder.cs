using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tasks
{
    class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            int result = 0;
            char[] charArray = roman.ToCharArray();
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case 'I':
                        intArray[i] = 1;
                        break;
                    case 'V':
                        intArray[i] = 5;
                        break;
                    case 'X':
                        intArray[i] = 10;
                        break;
                    case 'L':
                        intArray[i] = 50;
                        break;
                    case 'C':
                        intArray[i] = 100;
                        break;
                    case 'D':
                        intArray[i] = 500;
                        break;
                    case 'M':
                        intArray[i] = 1000;
                        break;
                }
            }
            int k = 0;
            if (intArray.Length == 1)
                return intArray[0];
            while (k < intArray.Length)
            {
                if( k + 1 >= intArray.Length)
                {
                    result += intArray[k];
                    break;
                }
                    
                if (intArray[k] < intArray[k + 1])
                {
                    result += intArray[k + 1] - intArray[k];
                    k += 2;
                }
                else if (intArray[k] == intArray[k + 1])
                {
                    result += intArray[k] + intArray[k + 1];
                    k += 2;
                }
                else
                {
                    result += intArray[k];
                    k++;
                }
            }
           
            return result;
        }
        public static int sdf(string s)
        {
            int result = 0;
            char[] charArray = s.ToCharArray();
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case 'I':
                        intArray[i] = 1;
                        break;
                    case 'V':
                        intArray[i] = 5;
                        break;
                    case 'X':
                        intArray[i] = 10;
                        break;
                    case 'L':
                        intArray[i] = 50;
                        break;
                    case 'C':
                        intArray[i] = 100;
                        break;
                    case 'D':
                        intArray[i] = 500;
                        break;
                    case 'M':
                        intArray[i] = 1000;
                        break;
                }
            }
            int a=0;
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                if (i == 0)
                    break;
                   if (intArray[i] > intArray[i - 1])
                    
                        a += a - intArray[i - 1];
                    
                    else
                        a += intArray[i - 1];
                
            }
            return a;
        }
    }
}
