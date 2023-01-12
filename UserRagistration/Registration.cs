using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class Registration
    {
        public void FirstNameUC1()
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] FirstName = { "Pallavi" ,"Priyansh","jayesh","kushal"};

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
