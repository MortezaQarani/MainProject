using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class AgeCheker
    {
        public static int AgeChekerMethod()
        {
            bool ageFlag = true;
            int top;
            int age = 0;
            while (ageFlag)
            {
                top = Console.GetCursorPosition().Top;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please ente your age:");
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition("Please ente your age:".Length + 1, top);
                    age = int.Parse(Console.ReadLine());
                    ageFlag = false;
                    if (age < 15 || age > 130)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your registration faild. because, your age is out of range.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid value.");
                }
            }
            return age;
        }
    }
}
