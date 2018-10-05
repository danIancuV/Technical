using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_vs_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new BiDimensionalShape(10, 10);

            object squareShape = square; //boxing
            square.x = square.y = 20;

            Console.WriteLine("The square coordinates values are: {0} ", ((BiDimensionalShape)squareShape).x); //unboxing
        }
    }
}
