using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_P23
{   public class Base
    {
        public string _Name;
        public int _Id;
        public virtual void PrintName()
        {
            Console.WriteLine("Base Class Full Name and Id is = {0} {1}",_Name,_Id);
        }
    }
    public class Child : Base
    {
        public override void PrintName()
        {
            Console.WriteLine("Child Class Full Name and Id is = {0} {1}", _Name, _Id);
        }
    }
    public class Child2 : Base
    {
        public override void PrintName()
        {
            Console.WriteLine("Child2 Class Full Name and Id is = {0} {1}", _Name, _Id);
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            Base C1 = new Base();
            C1._Name = "Base";
            C1._Id = 1;
            C1.PrintName();
            Base Ch1 = new Child();
            Ch1._Name = "Child";
            Ch1._Id = 2;
            Ch1.PrintName();
            C1.PrintName();
           
            Base Ch2 = new Child2();
            Ch2._Name = "Child2";
            Ch2._Id = 3;
            Ch2.PrintName();
            C1.PrintName();
        }
    }
}
