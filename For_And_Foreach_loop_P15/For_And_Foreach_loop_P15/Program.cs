using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_And_Foreach_loop_P15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach loop 
           /* int []number = new int[3];
            number[0] = 101;
            number[1] = 102;
            number[2] = 103;

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }*/

            //for loop

           /* for (int i=0; i<=20; i++)
                {
                Console.WriteLine(i);
            }*/

            //for loop with break statement

            /*for(int i=0; i<=20; i++)
            {
                if(i==10)
                { break; }  
                
                Console.WriteLine(i);
            }*/

            //for loop with continue statement

           /* for(int i=0; i<=20;i++)
            {
                if(i%2==1)
                {
                    continue;
                }
                
                Console.WriteLine(i);

            }*/

        }
    }
}
