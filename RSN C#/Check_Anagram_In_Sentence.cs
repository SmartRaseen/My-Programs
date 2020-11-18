using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "The pot is in the top floor." + " He saw what was a good film." +
                         " hello the word parts is an anagram of strap and traps." + " Moreover 24 is 42. Please stop for pots"; ;
            String[] sar = str.Split(' ');
            int n = sar.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (sar[j].Length == sar[k].Length)
                    {
                        if (!sar[j].Equals(sar[k]))
                        {
                            bool y = isAnagram(sar[j], sar[k]);
                            if (y)
                            {
                                Console.WriteLine("\t" + sar[j] + " " + sar[k]);
                            }
                        }
                    }
                }
            }
            bool isAnagram(String word, String anagram)
            {
                char[] chars = word.ToCharArray();
                //loop through each character in `word`
                foreach (char c in chars)
                {
                    int index = anagram.IndexOf(c);
                    //if it exists in `anagram`, remove it using a combination of `substring` calls, else return false
                    if (index != -1)
                    {
                        anagram = anagram.Substring(0, index) + anagram.Substring(index + 1, anagram.Length - (index + 1));
                    }
                    else
                    {
                        return false;
                    }
                }
                return (anagram.Equals(String.Empty));
            }
            Console.ReadLine();
        }
    }
}
