using System;

namespace Const_vs_Readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            var varr = new Variables();
            Console.WriteLine("Values are: {0}, {1}, {2}", Variables.Co, varr.Re, Variables.StRe ); 
        }
    }

    public class Variables
    {
        public const int Co = 9;

        public readonly double Re = 9;

        public static readonly int StRe = 9;

        public Variables()
        {
            //Co = 10;
            Re = Math.PI; //can be changed further in non-static parametrized ctor
            //StRe = 10;
        }

        static Variables()
        {
            //Co = 10;
            //Re = Math.PI;
            StRe = 10; //no change further
        }
    }
}
