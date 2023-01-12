using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRagistration
{
    class CheckingPassword
    {
        public void Password()
        {
            //UC5 Checking PassWord
            //string Pattern = "^{8}[A-Z]{1,}[a-z]{1,}?[@,#,_,.,&,$][a-z0-9]{1,}$";
            //string[] Password1 = { "Pallu30","Jayu123@Ko"};

            string Pattern = "^{8,}[A-Z]{1,}[a-z0-9]{1,}?([.,@,-,#,&,$,*])[a-z0-9]{1,}$";
            string[] Password1 = { "Piyu@3296", "all123@g123", "Jayu12.g123", "12pari#pari", "Jayu123@ko","Pall@12" };

            foreach (string input in Password1)
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
