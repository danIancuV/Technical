using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParam
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Wirtek";
            Console.WriteLine("Inside Main, before calling the change method, the string value is: {0}", mystring);            
            ModifyString(ref mystring);
            Console.WriteLine("Inside Main, after calling the change method, the string value is: {0}", mystring);
            Console.ReadKey();

            char[] mychararray = new char[] {'a', 'b', 'c'};
            Console.WriteLine("Inside Main, before calling the change method, the array first element is: {0}", mychararray[0]);
            ModifyCharArray(ref mychararray);
            Console.WriteLine("Inside Main, after calling the change method, the array first element is: {0}", mychararray[0]);
        }

        static void ModifyString(ref string modifstring)
        {
            modifstring = "viking";
            Console.WriteLine("Inside the change method the string value is: {0}", modifstring);           
        }

        static void ModifyCharArray(ref char[] modifarray)
        {
            modifarray[0] = '1';
            modifarray = new char[] { 'd', 'e', 'f' };           
            Console.WriteLine("Inside the change method, the array first element is: {0}", modifarray[0]);          
        }
    }
}

