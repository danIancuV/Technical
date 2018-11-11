using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutablevsImmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------imutable

            string a = "Wirtek";
            string b = a;
            bool areEqual = Object.ReferenceEquals(a, b);
            Console.WriteLine("Strings are equal: {0}", areEqual);

            a = "Viking";
            bool areEqualafterModif = Object.ReferenceEquals(a, b);
            Console.WriteLine("Strings are equal: {0}", areEqualafterModif);

            //---------------------------mutable

            StringBuilder stra = new StringBuilder();
            stra.Append("Wirtek");

            StringBuilder strb = new StringBuilder();
            strb = stra;
            bool strAreEqual = Object.ReferenceEquals(stra, strb);
            Console.WriteLine("Strings are equal: {0}", strAreEqual);

            stra.Append("viking");
            bool strAreEqualafterModif = Object.ReferenceEquals(stra, strb);
            Console.WriteLine("Strings are equal: {0}", strAreEqualafterModif);

            //-------------------------------imutable

            int x = 1;
            int y = x;
            bool areEqualInts = x.Equals(y);
            Console.WriteLine("Ints are equal: {0}", areEqualInts);

            x = 2;
            bool areEqualIntsafterModif = x.Equals(y);
            Console.WriteLine("Ints are equal: {0}", areEqualIntsafterModif);


            //-------------------------------mutable   

            var firstarr = new[] {1};
            var secondarr = firstarr;
            bool arrAreEqual = Object.ReferenceEquals(firstarr, secondarr);
            Console.WriteLine("Arrays are equal: {0}", arrAreEqual);

            //firstarr= new[] {2};
            firstarr[0] = 2;
            bool arrAreEqualafterModif = Object.ReferenceEquals(firstarr, secondarr);
            Console.WriteLine("Arrays are equal: {0}", arrAreEqualafterModif);
        }
    }
}
