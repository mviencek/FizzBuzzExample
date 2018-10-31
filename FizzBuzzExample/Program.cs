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
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {
                ParseFizzBuzz(i);
            }
       
        }
    }
}
