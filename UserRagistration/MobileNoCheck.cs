using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class MobileNoCheck
    {
        public void Mobile()
        {
            //UC4 Checking Mobile
            string Pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] Mobile = { "91 9919819801" };

            foreach (string input in Mobile)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
    }
}
