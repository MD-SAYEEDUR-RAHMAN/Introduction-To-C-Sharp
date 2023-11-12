using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_P19
{   public class Customer
    {
        string First_Name;
        string Last_Name;
        public Customer() : this("No First Name Given", "No Last Name Given")
        {

        }
        public Customer(string first_Name, string last_Name)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
        }
        public void print()
        {
            Console.WriteLine("Full Name Is:{0}", First_Name + " " + Last_Name);
        }
        ~Customer()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.print();
            Customer C2 = new Customer("Kabir", "Sing");
            C2.print();

        }
    }
}
