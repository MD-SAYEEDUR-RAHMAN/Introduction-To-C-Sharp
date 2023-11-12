using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding_P22
{
    public class Base
    {
        public string _Name;
        public int _Id;
        public Base()
        {
            Console.WriteLine("Base Class Constructor Called");
        }
        public Base(string msg)
        {
            Console.WriteLine(msg);
        }
        public void printName()
        {
            Console.WriteLine("Full name and Id is {0}, {1}", _Name, _Id);
        }
    }
    public class Child : Base
    {

        public new void printName()  //Using New Keyword for Base Class Method Hiding 
        {
            base.printName(); //Invoke Base Class Method
            //Console.WriteLine("Full and Final name and Id is {0} {1}", _Name, _Id);
        }

    }
    public class Child2 : Base
    {

        public new void printName() //Using New Keyword for Base Class Method Hiding 
        {
            
            Console.WriteLine("Full and Final name and Id is {0} {1}", _Name, _Id);
        }

    }
    internal class Program
    {   

        static void Main(string[] args)
        {
            Child C1 = new Child();
            C1._Name = "Mark";
            C1._Id = 1;
            
            C1.printName();
            ((Base)C1).printName(); //Invoke Base Class Method
            Child2 C2 = new Child2();
            C2.printName();

            Base C3 = new Child2(); //Base Class Reference Variable point to a Child Class Reference Variable
            C3.printName(); //Invoke Base Class Method Again
           
            
        }
    }
}
