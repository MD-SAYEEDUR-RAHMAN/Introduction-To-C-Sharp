using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_P32
{
    public abstract class Abs
    {
        public abstract void Method();
        public void Method2() //contain method without abstract keyword
        {
            Console.WriteLine("Method implemented possible without abstract keyword");
        }
    }
   
    internal class Program:Abs //Non-Abstract class must implement all abstract method
    {
        public override void Method()
        {
            Console.WriteLine("Abstract method implement done");
        }
        static void Main(string[] args)
        {   
            Program p = new Program();//
            p.Method();
            p.Method2(); 
            Abs ab =new Program(); //Parent reference variable can point to a derived class variable
            ab.Method();
            ab.Method2();
        }
    }
}
