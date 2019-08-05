using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palindrome
{
    class Program
    {
        /*requirement: Check to see if a string is a palindrome
        Constraint: Should not be null
                    remove spaces and punctuations
        */
        static void Main(string[] args)
        {
            string s1 = "Was it a car or a cat I saw?";
            string s2 = "No 'x' in Nixon";
            string s3 = "Not a Palindrome";
            if (IsPalindrome(s3))
            {
                Console.WriteLine("{0} is a palindrome", s3);
            }
            else
            {
                Console.WriteLine("{0} is NOT a palindrome", s3);
            }
        }
        public static bool IsPalindrome(string testString)
        {
            if (testString == null)
                return false;

            var s1 = new StringBuilder();
            char[] charStringArray;
            string reversedString;
            foreach (char c in testString)
            {
                //add to string builder only if it is not a punctuation
                if (!char.IsPunctuation(c))
                    s1.Append(c);
            }
            charStringArray = s1.ToString().ToLower().Replace(" ", "").ToCharArray();
            testString = s1.ToString().ToLower().Replace(" ", "");
            Array.Reverse(charStringArray);
            reversedString = new string(charStringArray);

            if (testString.Equals(reversedString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
