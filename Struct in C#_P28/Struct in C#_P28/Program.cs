using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_in_C__P28
{
       public struct Student
       {
            private int _id; //Creat private field
            private string _name;

            public Student (int Id, string name) //Create Constructor
            {
                this._id = Id;
                this._name = name;
            }

            public int ID //create property
            {
                get { return this._id;}
                set { this._id = value;}
            }
            public string Name //Another Property
            {
                get { return this._name;}
                set { this._name = value;}
            }
            public void Method()
            {
                Console.WriteLine("Student Id is:{0} and Student Name is:{1}",this._id,this._name);
            }
           

        }
        public class program
        {
            static void Main(string[] args)
            {
                    Student st1 = new Student(101, "Nahid"); //peramiterized constructor called
                    st1.Method();
                    Student st2 = new Student();//Value set to property and called print method
                    st2.ID = 102;
                    st2.Name = "Sayeed";
                    st2.Method();

                    Student st3 = new Student //object Initializer Syntax and called method
                    {
                        ID = 102,
                        Name = "Nohan"
                    };

                    st3.Method();

            }
            
        }
        
    
}
