using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp3
{
    public class StringCheker
    {
        public static string Consolemethod(string lastOrFirst)
        {
            string string1 = "";
            Console.ForegroundColor = ConsoleColor.Green;
            int top = Console.GetCursorPosition().Top;
            Console.WriteLine($"Please enter your {lastOrFirst}:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition($"Please enter your {lastOrFirst}:".Length, top);
            string1 = Console.ReadLine();
            return string1;
        }
        public static bool ChekString(string firstName, string lastOrFirst)
        {
            bool firstNameFlag;
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid character in {lastOrFirst}.");
                firstNameFlag = true;
            }
            else
            {
                firstNameFlag = false;
            }
            return firstNameFlag;
        }
    }
}
