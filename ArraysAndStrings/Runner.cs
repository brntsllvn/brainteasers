using System;
using System.Linq;

namespace ArraysAndStrings
{
    public static class Runner
    {
        public static bool UniqueString(string input)
        {
            if (input == null || input.Length < 2)
            {
                return true;
            }

            return input.ToCharArray()
                        .GroupBy(ch => ch)
                        .All(x => x.Count() == 1);
        }

        public static bool IsPermutation(string str, string perm)
        {
            if (str == null && perm == null) return true;
            if (str == null || perm == null) return false;

            int[] counts = new int[256];
            foreach (var ch in str.ToCharArray())
            {
                try
                {
                    counts[ch]++;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            foreach (var ch in perm.ToCharArray())
            {
                counts[ch]--;
            }

            var result = counts.All(count => count == 0);
            return result;
        }
    }
    
    
}