using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_In_C__P16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Method1(30);

            Program instance1 = new Program();
           int sum = instance1.Method2(5, 25);
            Console.WriteLine(sum);

        }
        public static void Method1(int target) //static type method with parameter
        {
            int start = 0;
            while(start<= target)
            {
                Console.WriteLine(start);
                start++;
            }
        }

        public int Method2(int a, int b) // Instance Method with Parameter.
        {
            return a + b;
        }   
    }
}
