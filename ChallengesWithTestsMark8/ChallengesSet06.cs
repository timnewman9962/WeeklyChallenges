using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            if (!ignoreCase)
                return words.Contains(word);
            return words.Contains(word, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;
            for(int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            bool match;
            for (int i = str.Length-1; i >= 0; i--)
            {
                match = false;
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        match = true;
                        break;
                    }
                }
                if (match == false)
                    return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int maxConsec = 0;
            for (int i = 0; i < numbers.Length-1;)
            {
                int cnt = 1;
                while (i < numbers.Length-1 && numbers[i] == numbers[++i])
                    cnt++;
                maxConsec = Math.Max(maxConsec, cnt);
            }
            return maxConsec;
        }
        
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
                return new double[0];
            int cnt = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                if (++cnt % n != 0)
                {
                    elements.RemoveAt(i);
                    i--;
                }
            }
            return elements.ToArray();
        }
    }
}
