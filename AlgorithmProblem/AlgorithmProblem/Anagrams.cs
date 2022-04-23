using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class Anagrams
    {

        public static void FindAnagram()
        {
            Console.WriteLine("Enter the String 1 :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the String 2 :");
            string str2 = Console.ReadLine();

            //Store the string in the char array after converting to lower case
            char[] ch1 = str1.ToUpper().ToCharArray();
            char[] ch2 = str2.ToUpper().ToCharArray();

            //Sort the characters in the char array
            Array.Sort(ch1);
            Array.Sort(ch2);

            //object of string by passing the char array to it
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);

            if (newString1 == newString2)
            {
                Console.WriteLine("Both the strings are anagrams!");

            }
            else
            {
                Console.WriteLine("Both the strings are not anagrams!");
            }
        }
    }
}

