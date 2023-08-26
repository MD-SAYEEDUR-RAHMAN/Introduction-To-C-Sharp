using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Type_p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text = "Rahman_Md_Sayeedur";//Normal String print
            Console.WriteLine(Text);

            String Text_Dblqtsn = "\"Cha or Coffee\""; //String with double quatation(Escape Sequence)
            Console.WriteLine(Text_Dblqtsn);

            String Text_Bslash = "C:\\Users\\Nohan\\Downloads\\Thursday_Select\\Thursday_Select ";
            Console.WriteLine(Text_Bslash); //String with backslash(Esacape Sequence)

            String Text_BSlash1 = @"C:\Users\Nohan\Downloads\Thursday_Select\Thursday_Select";
            Console.WriteLine(Text_BSlash1);//String with backslash (Using Varbatim Literal)




        }
    }
}
