using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C__P30
{
    internal class Program
    {   interface Icustomer //This is Interface and it has Method Declaration but No Implementation
        {
            void print();
        }
        interface Icustomer2
        {
            void Print2();
        }
        interface I1
        {
            void Method1();
        }
        interface I2: I1 //Multilevel
        {
            void Method2();
        }
        public class Multilevel : I2 //Multilevel and Implement both method
        {   public void Method1()
            {
                Console.WriteLine("I1 interface Method");
            }
            public void Method2()
            {
                Console.WriteLine("I2 interface Method");
            }
        }
        public class Customer : Icustomer, Icustomer2 //Multiple Interface is possible but multiple class is not possible in C#
        {
            public void print() //Interface method implementation1
            {
                Console.WriteLine("Print1");
            }
            public void Print2() //Interface method implementation2
            {
                Console.WriteLine("Print2");
            }
        }
        static void Main(string[] args)
        {   
            //Icustomer Icu1 = new ICustomer  Not possible Coz Interface method has no implementation 
            Icustomer customer = new Customer();//possible 
            customer.print();
            Customer cast = new Customer();//Also possible
            cast.Print2();
            I2 i1 = new Multilevel();//Multilevel object creating for calling duel interface
            i1.Method1();
            i1.Method2();
        }
    }
}
