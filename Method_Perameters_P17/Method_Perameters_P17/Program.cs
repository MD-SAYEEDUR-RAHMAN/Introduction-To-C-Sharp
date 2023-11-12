using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Method_Perameters_P17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            Program.Method1(i); //Passing Value
            Console.WriteLine(i);// Output will be 0;

        }
        public static void Method1(int j)//receive value not reference or same location
        {
             j = 20 ;
            Console.WriteLine(j);//output will be 20*/

            /*int i = 0;
            Program.Method2(ref i);//passing reference
            Console.WriteLine(i); //output will be 20
            
        }

        public static void Method2(ref int j)//receive reference not value...They are pointing to the same location
        {
            j = 20;*/
            /* int sum = 0;
             int product = 0;
             MethodOut(10, 20, out sum, out product);
             Console.WriteLine("Sum = {0} & Product = {1}", sum, product);
         }
         public static void MethodOut(int a, int b, out int sum, out int product)
         {
             sum = a + b;
             product = a * b;*/
            /*int[] numbers = new int[4];
            numbers[0] = 200;
            numbers[1] = 300;
            numbers[2] = 400;
            numbers[3] = 500;

            // ParamsMethod(); without parameter passing
            //ParamsMethod(numbers); initialize array and passing it to method
            ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8); 
        }
        public static void ParamsMethod( params int[] numbers)
        {
            Console.WriteLine("Total element is:{0}",numbers.Length);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }*/
        }
    }
}
