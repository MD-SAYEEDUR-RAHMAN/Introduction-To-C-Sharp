using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties_in_C__Encapsulation__P26
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmark = 35;

        public void SetID(int Id)
        {
            if (Id < 0)
            {
                throw new Exception("Student id can not be Negative");
            }
            this._id= Id;
        }
        public int GetID()
        {
            return this._id;
        }
       public void SetName (string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Student name can not be Null or Empty");
            }
            this._name= Name;
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(this._name))
            {
                throw new Exception("No Name");
            }
            else
            {
                return this._name;
            }
        }
        public int GetPassmark()
        {
            return this._passmark;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
           s.SetID(20);
            s.SetName("Sayeed");
            Console.WriteLine("Student ID is:{0}, Name is: {1} and Passmark is:{2}", s.GetID(),s.GetName(),s.GetPassmark());
        }
    }
}
