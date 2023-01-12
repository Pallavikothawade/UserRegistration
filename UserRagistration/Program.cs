using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UserRagistration;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome The User Ragistration Program******");
            Console.WriteLine("Please Enter The choice");
            Console.WriteLine("\n1:FirstName\n2:LastName\n3:Check Email\n4:Mobile Number\n5:Check The Password\n6:Upper Case");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Registration registration = new Registration();
                    registration.FirstNameUC1();
                    break;
                case 2:
                    Registration2 registration2 = new Registration2();
                    registration2.LastNameUC2();
                    break;
                case 3:
                    EmailChecking checkEmail = new EmailChecking();
                    checkEmail.Email();
                    break;
                case 4:
                    MobileNoCheck MNC = new MobileNoCheck();
                    MNC.Mobile();
                    break;
                case 5:
                    CheckingPassword checkingPassword = new CheckingPassword();
                    checkingPassword.Password();
                    break;
                    
            }
            Console.ReadLine();
            
        }
    }
}
