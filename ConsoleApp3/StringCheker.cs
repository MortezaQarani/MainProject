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
            string firstName = "";
            Console.ForegroundColor = ConsoleColor.Green;
            int top = Console.GetCursorPosition().Top;
            Console.WriteLine($"Please ente your {lastOrFirst}:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition($"Please ente your {lastOrFirst}:".Length, top);
            firstName = Console.ReadLine();
            return firstName;
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
