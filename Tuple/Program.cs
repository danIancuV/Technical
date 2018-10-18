using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            (string fullname, string mynickname, Emp myemployee) empDetail = GetEmployees();
            Console.WriteLine("The values are: {0}, {1}, {2}", empDetail.fullname, empDetail.mynickname, empDetail.myemployee);

            Tuple<string, Emp> tuple = GetEmployee();
            Console.WriteLine("The values are: {0}, {1}", tuple.Item1, tuple.Item2.height);
            //TODO: IL & ILDASM
        }

        public static (string n, string nk, Emp emp) GetEmployees()
        {
            string name = "Johnny";
            string nickname = "John";
            Emp emp = new Emp(63, 173);
            return (name, nickname, emp);
        }

        public static Tuple<string, Emp> GetEmployee()
        {
            Emp emp2 = new Emp(65, 175);
            string name2 = "Vlad";
            var tuple1 = new Tuple<string, Emp>(name2, emp2);
            return tuple1;
        }
    }

    public class Emp
    {
        public int weight, height;

        public Emp(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }
    }
}
