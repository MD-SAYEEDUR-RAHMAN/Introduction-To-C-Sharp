using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While_loop_P12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Target:");
            int userTarget = int.Parse(Console.ReadLine());
            /*int Start = 1; //For odd number
            while( Start <= userTarget)
            {
                Console.WriteLine(Start);
                Start= Start + 2;

            }*/
            int Start = 0; //For even Number
            while(Start <= userTarget)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
