using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SwitchStatementGoto_p12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalBill = 0;
            Start:
            Console.WriteLine("Please select your coffee size: 1-Small 2- Medium 3- Large");
            int userChoice = int.Parse(Console.ReadLine());
            
            switch (userChoice)
            {
                case 1:
                    totalBill += 100;
                    
                    break;
                    case 2:
                    totalBill += 200;
                    
                    break;
                    case 3:
                    totalBill += 300;
                    

                    break;
                    
                default:
                    Console.WriteLine("invalid choice");
                    goto Start;
                    
            }
            Decision:
            Console.WriteLine("Do you want to buy another coffee: Yes or No");
            string userDecision = Console.ReadLine();
            
            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Invalid {0} choice.Try again...", userDecision);
                    goto Decision;


            }
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Total bill is:{0}", totalBill);

        }
    }
}
