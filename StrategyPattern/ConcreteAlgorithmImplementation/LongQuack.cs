using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteAlgorithmImplementation
{
    public class LongQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I'm quakiiiiiiiiiiiiiiiiiiiinq!");
        }
    }
}
