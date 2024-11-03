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
                firstName = StringCheker.Consolemethod("firstname");
                firstNameFlag = StringCheker.ChekString(firstName, "firstname");        
            }
            return firstName;
        }
 
    }
}
