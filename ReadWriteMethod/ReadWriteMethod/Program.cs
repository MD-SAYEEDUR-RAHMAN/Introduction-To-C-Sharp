using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");

            string UserName = Console.ReadLine();

            // Console.WriteLine("Hello " + UserName);//Concatenation Method
            Console.WriteLine("Hello {0}", UserName);//Placeholder Syntax
            Console.WriteLine("Enter Your First Name Again:");
            string First_Name= Console.ReadLine();
            Console.WriteLine("Enter Your Last Name Again:");
            String Last_Name = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}",First_Name, Last_Name);

        }
    }
}
