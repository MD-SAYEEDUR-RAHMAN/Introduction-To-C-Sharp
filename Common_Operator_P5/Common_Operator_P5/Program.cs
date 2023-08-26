using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Operator_P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = 50; //Assignment Operator( = );
            int Num2 = 25;
            int result = Number / Num2; //Arithmatic Operator ( +, -,*,/,% )
            Console.WriteLine("Result is: {0}",result );

            if ( result == 0 ) //Comparison Operator ( ==,?=,>,>=,<,<=, )
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Not ok");
            }
            if (Number == 50 &&  Num2 == 25 ) //Conditional Operator (&&,||)
            {
                Console.WriteLine("Both number value is True");
            }
            else
            {
                Console.WriteLine("One Number value is Incorrect");
            }
            bool IsNumber = Number == 50 ? true : false; //Ternary Operator (?:)
            Console.WriteLine("Isnumber == 50 {0}", IsNumber);
        }
    }
}
