using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Question2_Practice
{
    internal static class MyStringBuilderExtension
    {
        public static int GetWordCount(this StringBuilder sb)
        {
            string s = sb.ToString();
            string[] words = s.Split(' ');
            int numOfWords = words.Length;

            // If the first word is a space, decrement the word count.
            string firsWord = words[0];

            if (string.IsNullOrWhiteSpace(firsWord))
            {
                numOfWords--;
            }


            // If the last word is a space, decrement the word count.
            string lastWord = words[words.Length - 1];

            if (string.IsNullOrWhiteSpace(lastWord))
            {
                numOfWords--;
            }


            return numOfWords;
        }
    }
}
