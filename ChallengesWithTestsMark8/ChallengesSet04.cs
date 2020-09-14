using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
                return 0;
            //int num = 0;
            //foreach(var n in numbers)
            //{
            //    num += n % 2 == 0 ? n : -n;
            //}
            //return num;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //int shortest = str1.Length;
            //shortest = str2.Length < shortest ? str2.Length : shortest;
            //shortest = str3.Length < shortest ? str3.Length : shortest;
            //shortest = str4.Length < shortest ? str4.Length : shortest;
            //return shortest;

            var arr = new string[] { str1, str2, str3, str4 };
            return arr.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //int smallest = number1;
            //smallest = Math.Min(smallest, number2);
            //smallest = Math.Min(smallest, number3);
            //smallest = Math.Min(smallest, number4);
            //return smallest;

            var arr = new int[] { number1, number2, number3, number4 };
            return arr.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 < sideLength2 + sideLength3) &&
                   (sideLength2 < sideLength3 + sideLength1) &&
                   (sideLength3 < sideLength1 + sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return Int32.TryParse(input, out var num) ||
                Double.TryParse(input, out var num1) ||
                Decimal.TryParse(input, out var num2);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null)
                return true;
            //int nulls = 0;
            //foreach (var item in objs)
            //{
            //    if (item == null)
            //        nulls++;
            //}
            //return nulls > objs.Length - nulls;

            return objs.Count(x => x == null) > objs.Count() / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            //int sum = 0;
            //int nCnt = 0;
            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        sum += item;
            //        nCnt++;
            //    }
            //}
            //return nCnt == 0 ? 0 : (double)sum / nCnt;

            return numbers.Any(x => x % 2 == 0) ? (double)numbers.Where(x => x % 2 == 0).Average(): 0.0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int fact = 1;
            while (number > 1)
                fact *= number--;
            return fact;
        }
    }
}
