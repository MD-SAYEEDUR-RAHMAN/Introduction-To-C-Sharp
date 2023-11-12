using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_in_C__P36
{
    public delegate void delMethod(String Messeage_pass);
    internal class Program
    {
        public static void Function(string Messeage)
        {
            Console.WriteLine(Messeage);
        }
        static void Main(string[] args)
        {
            delMethod del1 = new delMethod(Function);
            del1("Calling Delegate");
            
            
        }
    }
}
