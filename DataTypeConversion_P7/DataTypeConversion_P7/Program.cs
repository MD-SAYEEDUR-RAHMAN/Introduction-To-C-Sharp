using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion_P7
{
    internal class Program
    {
        static void Main(string[] args)
        {      //Implicit Conversion
            int Number = 10;
            float F = Number;
            Console.WriteLine(F);

            //Explicit Number(1.Using Cast & 2.Using Covert.To class)
            float Fnum = 1234562529625141515144.123F;
            int i = (int)Fnum; //Using Cast-Don't show exception it will show minimum number and loss information also
            //int i = Convert.ToInt32(Fnum);//Using Convert class-Show exception overflow and loss information
            
            Console.WriteLine(i);
            //For string we can use two data conversion method,one is Parse(),another one is TryParse()

            string word = "102";//if the string looks like "102FD" it will show exception,only valid number convert from string to int

            int St = int.Parse(word);
            Console.WriteLine(St);
            //Avoid exception we can use TryParse ,It will prevent exception and show true or false
            String Sentence = "1023";
            int result = 0;
            bool Issucess = int.TryParse(Sentence, out result);
            if(Issucess )
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid string");
            }



        }
    }
}
