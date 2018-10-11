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
            var empDetail = GetEmployees();
            Console.WriteLine("The values are: {0}, {1}, {2}", empDetail.n, empDetail.nk, empDetail.emp.height);

            var tuple = GetAllEmployees();
            Console.WriteLine("The values are: {0}, {1}", tuple.Item1, tuple.Item2.height);

        }

        public static (string n, string nk, Emp emp) GetEmployees()
        {
            string name = "Johnny";
            string nickname = "John";
            Emp emp = new Emp(63, 173);
            return (name, nickname, emp);
        }

        public static Tuple<string, Emp> GetAllEmployees()
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
