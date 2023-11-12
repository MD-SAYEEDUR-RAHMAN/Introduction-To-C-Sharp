using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_P25
{   
    internal class Program
    {   
        static void Main(string[] args)
        {
            Add(1, 2); //
            Add(1, 2, 3);// Depend on Number of Perameter
            Add(1, 1.0f); //Depend on Type of Perameter
            Add(1,2,7,8,9,10,11); //Depend on kind of perameter & 7,8,9,10,11 are array element


        }
        public static void Add(int x , int y)
        {
        }
        public static void Add(int x, int y,int z)
        {
        }
        public static void Add(int x, float y)
        {

        }
        public static void Add(int x, int y, params int[] Arr) //Parameter array using params keyword
        {
            Console.WriteLine("Total Array Number is {0}",Arr.Length);
            foreach (int i in Arr)
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
