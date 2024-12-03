using System;

namespace Assignment5._2._1
{
    internal class Program
    {
        //1. Given a string s consisting of words and spaces, return the length of the last word in the string.
        //A word is a maximal substring consisting of non-space characters only.
        //Example 1:
        //Input: s = "Hello World"
        //Output: 5
        //Explanation: The last word is "World" with length 5.
        //Example 2:
        //Input: s = " fly me to the moon "
        //Output: 4
        //Explanation: The last word is "moon" with length 4.
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int result = LastWordLength(input);

            Console.WriteLine($"The length of the last word is: {result}");
        }
        static int LastWordLength(string s)
        {
            int length = 0;
            int i = s.Length - 1;

            if  (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }
    }
}
