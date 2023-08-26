using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_In_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool b = true;
           // b = 1.025;// Error coz Boolean means only true or False
           /* Minimum and Maximum Value that we can store in C# is given below*/
            //int i = 0;
            Console.WriteLine("Minimum value is: {0}",int.MinValue);
            Console.WriteLine("Maximum value is: {0}",int.MaxValue);

            Console.WriteLine("Minimum value is: {0}", float.MinValue);
            Console.WriteLine("Maximum value is: {0}", float.MaxValue);
            float F = 123456.456f;
            Console.WriteLine(F);

            Console.WriteLine("Minimum value is: {0}", double.MinValue);
            Console.WriteLine("Maximum value is: {0}", double.MaxValue);
            double D = 204060802040612.12345;
            Console.WriteLine(D);

            Console.WriteLine("Minimum value is: {0}", decimal.MinValue);
            Console.WriteLine("Maximum value is: {0}", decimal.MaxValue);
            decimal DC = 204060802040612456.12345M;
            Console.WriteLine(DC);



        }
    }
}
