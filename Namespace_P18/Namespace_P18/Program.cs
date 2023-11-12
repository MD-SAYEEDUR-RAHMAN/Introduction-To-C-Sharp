using System;
using PATA = ProjectA.TeamA;
using ProjectA.TeamB;

namespace Namespace_P18
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProjectA.TeamA.ClassA.print(); Using full namespace
            //ProjectA.TeamB.ClassA.print();
            //ClassA.print(); Could not find which one is come from TeamA or TeamB
            PATA.ClassA.Print();//Alias
            ClassA.Print();
        }
    }
}


    


