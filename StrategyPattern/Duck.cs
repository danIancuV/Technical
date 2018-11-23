using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Duck
    {
        private readonly IFlyBehaviour _flyBehaviour;
        private readonly IQuackBehaviour _quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

    }
}
