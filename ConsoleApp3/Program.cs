using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            string firstName;
            string lastName;
            long phoneNumber;
            int age = 0;
            firstName = FirstNameCheker.FirstNameChekerNameMethod();
            lastName = LastNameCheker.LastNameChekerMethod();
            age = AgeCheker.AgeChekerMethod();
            phoneNumber = PhoneNumber.PhoneNumberMethod();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nA user was registered with the following information:\nName: {firstName} {lastName}\nPhone number: 0{phoneNumber}\nAge: {age} ");
        }
    }
}