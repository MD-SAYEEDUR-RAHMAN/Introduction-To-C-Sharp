using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_in_C__P31
{
    internal class Program
    {
        interface I0
        {
            void Method();//Interface 1,2 Method same
        }
        interface I1
        {
            void Method();//Interface 1,2 Method same
        }
        interface I2
        {
            void Method();//Interface 1,2 Method same
        }
        public class Duel: I1, I2 //Multiple interface 
        {
            public void Method() //Default Method Implementation
            {
                Console.WriteLine("Method0");
            }
            void I1.Method() //Interface 1 Mention and  Method Implementation
            {
                Console.WriteLine("Method1");
            }
             void I2.Method() //Interface 1 Mention and  Method Implementation
            {
                Console.WriteLine("Method2");
            }
        }
        static void Main(string[] args)
        {
            Duel duel = new Duel();
            duel.Method(); //Default method call
            ((I1)duel).Method(); //Same method call from different interface using type cast object variable 
            ((I2)duel).Method(); //Same method call from different interface using type cast object variable 
        }
    }
}
