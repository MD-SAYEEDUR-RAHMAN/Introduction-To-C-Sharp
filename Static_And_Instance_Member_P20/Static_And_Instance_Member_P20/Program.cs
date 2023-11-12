using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_And_Instance_Member_P20
{
    internal class Program
    {
        class Circle
        {
            public static float _PI; //static field 
            int _radious;

            static Circle() //static constructor
            {
                Console.WriteLine("Static Constructor called first");//before instance constructor call
                Circle._PI = 3.141F;
            }

            public   Circle(int  radious)
            {
                Console.WriteLine("Instance Contructor called when creating new object");
                this._radious = radious;
            }
            public float calculatearea()
            {
                return Circle._PI* this._radious* this._radious;
            }


        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Circle._PI);
            Console.WriteLine("Check");
            Circle c1 = new Circle(5);
            float Area1=c1.calculatearea();
            Console.WriteLine("Total area is {0}", Area1);



        }
    }
}
