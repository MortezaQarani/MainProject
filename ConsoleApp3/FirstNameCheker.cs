using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FirstNameCheker
    {
        public static string FirstNameChekerNameMethod()
        {
            string firstName = null;
            bool firstNameFlag = true;
            while(firstNameFlag)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                int top = Console.GetCursorPosition().Top;
                Console.WriteLine("Please ente your first name:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition("Please ente your first name:".Length, top);
                firstName = Console.ReadLine();
                if( !Regex.IsMatch(firstName,@"^[a-zA-Z]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character in FirstName.");
                    firstNameFlag = true;
                }
                else
                {
                    firstNameFlag = false;
                }         
            }
            return firstName;
        }
    }
}
