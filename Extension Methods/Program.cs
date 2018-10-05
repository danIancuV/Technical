using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = "dani";
            string result = strName.ChangeFirstLetterCase();

            Console.WriteLine(result);           
        }
    }
}
