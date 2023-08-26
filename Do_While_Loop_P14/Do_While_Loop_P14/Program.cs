using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Do_While_Loop_P14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userDecide = " ";
            do
            {
                Console.WriteLine("Please Enter Your Target:");
                int userTarget = int.Parse(Console.ReadLine());
                int Start = 0;
                while (Start <= userTarget)
                {
                    Console.WriteLine(Start);
                    Start = Start + 2;
                }


                do

                {


                    Console.WriteLine("Do you want to Continue again- Yes or No");
                    userDecide = Console.ReadLine().ToUpper();
                    if (userDecide != "YES" && userDecide != "NO")
                    {
                        Console.WriteLine("Invalid Selection...Try again:");
                    }
                } while (userDecide != "YES" && userDecide != "NO");
            } while (userDecide == "YES"); 

            
        }

    }
}
