using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteAlgorithmImplementation
{
    public class SupersonicFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying supersonic");
        }
    }
}
