using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Array_p8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr; //Creating an array
            arr = new int[] { 1, 2, };// Insert value to it

            string[] arr2 = new string[] { "s", "f" };//Create an array of two elements without specifying the size
            
            string[] arr3 = new string[4] { "a", "b", "c", "d" };//Create an array of four elements with specifying the size four

            Console.WriteLine(arr);
            Console.WriteLine(arr2);
            Console.WriteLine(arr3);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            int[] arr5 = new int[3];
            arr5[0] = 1;
            arr5[1] = 2;
            arr5[2] = 3;
            for (int i = 0;i < arr5.Length; i++)
            {
                Console.WriteLine(arr5[i]);
            }


        }
    }
}
