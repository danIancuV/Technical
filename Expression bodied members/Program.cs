using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Dan");
            Console.WriteLine(p.ToString());
            p.DisplayName();
        }
    }

    public class Person
    {
        private string _fname;

        //private string Name
        //{
        //    get { return _fname; }
        //    set { _fname = "Daniel"; }
        //}

        //public Person(string firstname)
        //{
        //    fname = firstname;          
        //}

        //public override string ToString()
        //{
        //    return $"FirstName:{fname}";
        //}

        //public void DisplayName()
        //{
        //    Console.WriteLine(ToString());
        //}

        private string Name
        {
            get => _fname;
            set => _fname = value; //for property
        }

        public Person(string firstname) => Name = firstname; // for constructor

        public override string ToString() => $"FirstName:{Name}"; // for method

        public void DisplayName() => Console.WriteLine(ToString()); //for method
    }
}
