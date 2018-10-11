using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_interface_implementation
{
    class Program : IFirstInterface, ISecondInterface, IThirdInterface, IFourthInterface, IFifthInterface
    {    

        static void Main(string[] args)
        {
            Program p = new Program();
            ((IFirstInterface)p).InterfaceMethod();
            ((ISecondInterface)p).InterfaceMethod();
            p.InterfaceMethod();
            Console.WriteLine("Myfield property  value is: {0}", ((IFourthInterface)p).MyField);           
            Console.WriteLine("Myfield method returned value is: {0}", p.MyField());

            Console.WriteLine("Myfield property  value is: {0}", p.MyField1);
            Console.WriteLine("Myfield method returned value is: {0}", ((IFifthInterface)p).MyField1());
        }

        void IFirstInterface.InterfaceMethod() //explicit method implementation
        {
            Console.WriteLine("IFirstInterface method");
        }

        void ISecondInterface.InterfaceMethod() //explicit method implementation
        {
            Console.WriteLine("IsecondInterface method");
        }

        public void InterfaceMethod() //default method implementation
        {
            Console.WriteLine("IthirdInterface method");
        }

        int IFourthInterface.MyField => -1; //explicit property implementation 

        public int MyField() //default method implementation
        {
            return 0;
        }

        public int MyField1 => -2; //default property implementation

        int IFifthInterface.MyField1() //explicit method implementation
        {
            return 1;
        }
    }
}
