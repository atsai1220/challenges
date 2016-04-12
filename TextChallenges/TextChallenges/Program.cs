using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChallenges
{
    /// <summary>
    /// This program will reverse a string
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calls the reverse method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program main = new Program();
            main.reverse();
        }

        /// <summary>
        /// Will reverse another string as long as string length is > 1. 
        /// </summary>
        /// <returns></returns>
        public string reverse()
        {
            Console.Out.Write("Input: ");
            string argument = Console.ReadLine();

            if (argument.Length < 1)
            {
                return "";
            }
            else
            {
                string reversedString = "";
                char[] argArray = argument.ToCharArray();

                for (int i = argArray.Length - 1; i >= 0; i--)
                {
                    reversedString += argArray[i];
                }
                Console.Out.WriteLine(reversedString);
                reverse();
                return null;
            }
        }
    }
}
