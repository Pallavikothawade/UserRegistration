using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class EmailChecking
    {
        public void Email()
        {
            //UC3 Checking Email
            string Pattern = "^[a-z]{1,}([.][a-z]{1,})@[a-z]{1,}[.][a-z]{1,}[.][a-z]{1,}$";
            string[] Email1 = { "abc.xyz@bl.co.in" };

            foreach (string input in Email1)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} is valid Email", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid Email", input);
                }
            }
        }
    }
}
