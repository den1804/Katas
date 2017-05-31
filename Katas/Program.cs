using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Tasks;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, -2, 1, -5, -8, 5 };
            int[] bin = new int[] { 0, 1, 1, 0 };
            // Console.WriteLine(SumOfTwoLowestPositiveIntegers.sumTwoSmallestNumbers(arr));
            // Console.WriteLine(SumOfPositive.PositiveSum(arr));
            // int[] arr2 = new int[3];
            // Console.WriteLine(SumOfPositive.PositiveSum(arr2));
            // Console.WriteLine(OnesAndZeros.binaryArrayToNumber(bin));
            // Console.WriteLine(PrimesInNumbers.factors(86240));
            // List<int> returnResult = RectangleIntoSquares.sqInRect(8, 12);
            // foreach(int i in returnResult)
            //    Console.WriteLine(i);
            // Console.WriteLine(ReversedWords.ReverseWords("IYI VPKI "));
            // Console.WriteLine(MultiplesOf3And5.Solution(10));
            // Console.WriteLine(SimpleFractionToMixedNumberСonverter.MixedFraction("2/-10"));   
            // Console.WriteLine(RomanNumeralsDecoder.sdf("CDXVI"));
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            var result = numbers.Take(3).Skip(2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
