using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class Registration2
    {
        public void LastNameUC2()
        {
            //UC2 Checking Last Name
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] FirstName = { "Kothawade", "Shirole" };

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
