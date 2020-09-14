using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
                return false;
            return vals.Min() == false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return false;
            return numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
                return false;
            //bool isUpper = false;
            //bool isLower = false;
            //bool isNumber = false;
            //foreach(char c in password)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        if (char.IsUpper(c))
            //            isUpper = true;
            //        else
            //            isLower = true;
            //    }
            //    if (char.IsDigit(c))
            //        isNumber = true;
            //}
            //return isUpper && isLower && isNumber;

            return password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsDigit(x));
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.ToArray()[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0m)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return 0;
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new int[100 / 2];
            for (int i = 0; i <= odds.Length - 1; i++)
                odds[i] = 2 * i + 1;
            return odds;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            var str = new string[words.Length];
            words.CopyTo(str, 0);
            for (int i = 0; i < words.Length; i++)
                words[i] = str[i].ToUpper();

        }
    }
}
