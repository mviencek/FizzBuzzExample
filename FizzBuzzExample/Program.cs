using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExample
{
    class Program
    {
        //one liners are kind of unwieldly
        //number divisible by 3 print fizz
        //number divisible by 5 print buzz
        //number divisible by both 3 and 5 print fizzbuzz
        // else print number
        public static void ParseFizzBuzz(int number) {
            if (number % 3 == 0) {
                Console.Write("Fizz");
            }
            if (number % 5 == 0)
            {
                Console.Write("Buzz");
            }
            if (number % 5 != 0 && number % 3 != 0)
            {
                Console.Write(number.ToString());
            }            
            Console.WriteLine("");
        }

        //check for palindrome regardless of case or trailing/leading spaces.
        //trim string and treat prior to comparing
        public static bool IsPalindrome(String inputString) {
            bool palin = true;
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrEmpty(inputString.Trim())) {
                return false;
            }
            if (inputString.Trim().Length == 1) {
                return palin;
            }
            String treatedInput = inputString.ToUpper().Trim();
            int r = treatedInput.Trim().Length - 1;
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                char left = treatedInput[i];
                char right = treatedInput[r];
                if (left.CompareTo(right) != 0)
                {
                    return false;
                }
                r--;
            }
            return palin;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz test ---------------------------------------------------------");
            Console.WriteLine("");
            for (int i = 1; i <= 100; i++) {
                 ParseFizzBuzz(i);
             }

            Console.WriteLine("");
            Console.WriteLine("Palindrome test ---------------------------------------------------------");
            Console.WriteLine("");
            String s = null;
            Console.WriteLine("abcdcba is a palindrome: " + IsPalindrome("abcdcba")); //should be true
            Console.WriteLine("abddcba is a palindrome: " + IsPalindrome("abddcba")); //should be false
            Console.WriteLine("abCdcbA is a palindrome: " + IsPalindrome("abCdcbA")); //should be true
            Console.WriteLine("empty string is a palindrome: " + IsPalindrome("  "));  //should be false
            Console.WriteLine("null string is a palindrome: " + IsPalindrome(s)); //should be false
            Console.WriteLine("a is a palindrome: " + IsPalindrome("a")); //should be true

        }
    }
}
