using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class CheckEmail
    {
        public void Email()
        {
            //UC3 Checking Email
            string Pattern = "^[a-z]{1,}([.][a-z]{1,})@[a-z]{1,}[.][a-z]{1,}[.][a-z]{1,}$";
            string[] FirstName = { "abc.xyz@bl.co.in" };

            foreach (string input in FirstName)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid ", input);
                }
            }
        }
    }
}
