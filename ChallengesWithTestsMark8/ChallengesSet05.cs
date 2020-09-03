using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (++startNumber % n != 0) ;
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0)
                    item.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            var nArray = new int[numbers.Length];
            numbers.CopyTo(nArray, 0);
            Array.Sort(nArray);
            bool rtn = numbers.SequenceEqual(nArray);
            return rtn;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                    sum += numbers[i];
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
                return "";
            string sentence = "";
            foreach (var item in words)
            {
                if(!string.IsNullOrWhiteSpace(item))
                    sentence += item.Trim() + " ";
            }
            return sentence.Trim() + (string.IsNullOrWhiteSpace(sentence)? "": ".");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
                return new double[0];
            int nCnt = 1;
            for (int i = 0; i < elements.Count; i++)
            {
                if(nCnt++ % 4 != 0)
                {
                    elements.RemoveAt(i);
                    i--;
                }
            }
            return elements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null)
                return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
