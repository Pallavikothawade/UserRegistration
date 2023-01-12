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
            Registration registration = new Registration();
            registration.FirstNameUC1();

            Registration2 registration2 = new Registration2();
            registration2.LastNameUC2();

            Console.ReadLine();
        }
    }
}
