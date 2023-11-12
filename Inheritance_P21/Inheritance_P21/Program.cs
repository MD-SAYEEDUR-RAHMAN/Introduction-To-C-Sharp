using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_P21
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
            Console.WriteLine("Name {0} and Id Is {1}", _Name, _Id);
        }
        public class child : Base //Derived class inherit from Base Class 
        {
            public  child() : base("Base Class Parameterized Constructor called")
            {
                Console.WriteLine("Child Class Constructor Called");
            }
            public string _Nickname;
        }
        public class Program
    {  
        }
        static void Main(string[] args)
        {
            child c1 = new child();
            Base c2 = new child();
            /* c1._Name = "MArk";
             c1._Id = 1;
             c1._Nickname = "Williamson";
             c1.printName();
             Console.WriteLine("Full Name Is {0} {1}", c1._Name, c1._Nickname);*/




        }
       
    }
}
