using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp3
{
    internal class LastNameCheker
    {
        public static string LastNameChekerMethod()
        {
            string lastName = null;
            bool lastNameFlag = true;
            while (lastNameFlag)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                int top = Console.GetCursorPosition().Top;
                Console.WriteLine("Please ente your last name:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition("Please ente your first name:".Length, top);
                lastName = Console.ReadLine();
                if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character in lastName.");
                    lastNameFlag = true;
                }
                else
                {
                    lastNameFlag = false;
                }
            }
            return lastName;
        }

    }
}
