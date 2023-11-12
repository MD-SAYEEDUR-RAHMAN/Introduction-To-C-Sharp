using System;


namespace Poperties_and_Autometic_Properties_P27
{
    public class Student
    {
        private int _id;
        private string _name;
       public int age //Autometic Property
        {
            set;
            get;
        }

       /* public void SetID (int Id) //Using property with set method Parameter
        {
            if (Id < 0)
            {
                throw new Exception("Student ID can not be Negative");
            }
            this._id = Id;
        }*/
       public int ID //Using property directly in Field with read write method
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Student Id Can not be Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;    
            }
        }


        /*public int GetID() 
        { 
            return this._id; 
        } */ 
       /* public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Student name can not be Null or Empty");
            }
            this._name = Name;
            
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";

            }
            else
            {
                return this._name;
            }
        }*/
       public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student Name can not be NULL or Empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "NO Name" : this._name;
                
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
           Student st = new Student();
            st.age = 10;
            st.ID = 101;
           st.Name= "Sayeed";
            
            
            Console.WriteLine("Student Age Is:{0}", st.age);
            Console.WriteLine("Student Id is :{0}", st.ID);
            Console.WriteLine("Student Name Is:{0}", st.Name);
        }
    }

}

