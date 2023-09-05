using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Context contextA = new Context(new ConcreteStrategyA());
            contextA.doSomeBusinessLogic();

            Context contextB = new Context(new ConcreteStrategyB());
            contextB.doSomeBusinessLogic();
        }
    }
}
