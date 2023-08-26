using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement_p10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Number:");
           int userNumber = int.Parse (Console.ReadLine());


            /* if statement implement
            if (userNumber == 0)
            {
                Console.WriteLine("The Usernumber is Zero");
            }
            if (userNumber == 1)
            {
                Console.WriteLine("The Usernumber is One");
            }
            if (userNumber == 3) //when username is 3 then both condition is executed.If found one then it will check every condition.
            {
                Console.WriteLine("The Usernumber is Two");
            }
            if (userNumber == 3)
            {
                Console.WriteLine("The Usernumber is Three");
            } */


            //If else implement

            if (userNumber == 0)
            {
                Console.WriteLine("The Usernumber is Zero");
            }
            else if (userNumber == 2)//when i am using else if then it will check one by one conditon if found then skip others
            {
                Console.WriteLine("The Usernumber is One");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("The Usernumber is Two");
            }
            else 
            {
                Console.WriteLine("The Usernumber is not between zero to two");
            }


            // Difference between || and | .
            if (userNumber == 10 || userNumber==20)//when one condition is true then it will go for print.When I used | pipe it will check both even if matches found.On the other hand || checks one by one,if found then do not check next one. 
            {
                Console.WriteLine("The Usernumber is 10 or 20");
            }


            // Difference between && and &.
            if ( userNumber == 30 && userNumber == 40)
            {
                Console.WriteLine("The Usernumber is 30 or 40");
            }
            else
            {
                Console.WriteLine("Do no match properly");
            }

        }
    }
}
