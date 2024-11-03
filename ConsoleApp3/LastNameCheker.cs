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
                lastName = StringCheker.Consolemethod("lastname");
                lastNameFlag = StringCheker.ChekString(lastName, "lastname");
            }
            return lastName;
        }

    }
}
