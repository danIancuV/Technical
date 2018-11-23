using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.ConcreteAlgorithmImplementation;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck savageDuck = new Duck(new SupersonicFly(), new LongQuack());
            savageDuck.Fly();
            savageDuck.Quack();

            Console.WriteLine("--------------------------------------------");

            Duck domesticDuck = new Duck(new LowRangeFly(), new ShortQuack());
            domesticDuck.Fly();
            domesticDuck.Quack();
        }
    }
}
