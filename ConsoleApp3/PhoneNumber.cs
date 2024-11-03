using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class PhoneNumber
    {
        public static long PhoneNumberMethod()
        {
            int top;
            bool phonNumberFlag = true;
            string phone = "";
            long phoneNumber=0;
            while (phonNumberFlag)
            {
                top = Console.GetCursorPosition().Top;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please ente your phone number:");
                Console.SetCursorPosition("Please ente your phone number:".Length + 1, top);
                Console.ForegroundColor = ConsoleColor.Yellow;
                phone = Console.ReadLine();
                try
                {
                    if ((phone.Length == 11 && phone.StartsWith('0')) || (phone.Length == 10 && !phone.StartsWith('0')))
                    {
                        phoneNumber = long.Parse(phone);
                        phone = phoneNumber.ToString();
                        phonNumberFlag = false;
                    }
                    else if (phone.Length == 13 && phone.StartsWith("+98"))
                    {
                        phone = phone.Remove(0, 3);
                        phoneNumber = long.Parse(phone);
                        phonNumberFlag = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid phone number.");
                        phonNumberFlag = true;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character in phone number.");
                    phonNumberFlag = true;
                }
            }
            return phoneNumber;
        }
    }
}
