using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatemment_p11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("please enter your number:");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0)
            {
                Console.WriteLine("Usernumber is Zero");
            }
            else if(userNumber == 1)
            {
                Console.WriteLine("Usernumber is One");
            }
            else
            {
                Console.WriteLine("Invalid usernumber");
            }*/


            //Instead of if,else if, we can use switch statement:
            Console.WriteLine("Please enter your number:");
            int userNumber = int.Parse(Console.ReadLine());
            switch(userNumber)
            {
                case 0:
                    Console.WriteLine("Usernumber is zero");
                    break;//must be given break statement.
                case 1:
                    Console.WriteLine("Usernumber is one");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                   
                    Console.WriteLine("Usernumber is {0}", userNumber);
                    break;
               default:
                   Console.WriteLine("Invalid Usernumber");
                   break;
            }
               
        }
    }
}
