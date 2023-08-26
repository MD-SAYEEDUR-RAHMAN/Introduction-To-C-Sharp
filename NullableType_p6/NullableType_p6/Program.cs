using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType_p6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Value = null;//Error coz Value type is always Non Nullable
            int? Value = null;        // In c# we can create it nullable by using ? mark
            string Value1= null;//There is no Error coz its a Reference type ,Reference type can have nullable value
            
            /* Nullable type example is given below */
            bool? Areyoumajor = true;

            if (Areyoumajor == true)
            {
                Console.WriteLine("True");
            }
            else if(Areyoumajor == false)
            {
                Console.WriteLine("False");
            }
            else 
            { 
                Console.WriteLine("Null"); 
            }

            /*Using Null Coalescing Operator instead of if else nullable type*/
            int? TicketOnSale = null;

           // int availableTicket;

            /*if (TicketOnSale == null) 
            {
                availableTicket = 0;
            }
            else
            {
                //availableTicket = TicketOnSale.Value; //Right
                availableTicket = (int)TicketOnSale;
            }
            Console.WriteLine("Available Ticket is {0}", availableTicket);
            */
            int availableTicket = TicketOnSale ?? 0;
            Console.WriteLine("Available Ticket is {0}", availableTicket);
        }
    }
}
