using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = new Numbers<int>(4);
            firstNumber.Compare(1);
        }
    }

    public class Numbers<T>
    {
        public T Number { get; set; }

        public Numbers(T num)
        {
            this.Number = num;
        }

        public void Compare(T num)
        {
            if (Number.Equals(num))
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are NOT equal");
            }

        }
    }
}
