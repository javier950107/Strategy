using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        Strategy _Strategy { get { return _strategy; } set { _strategy = value; } }

        public void doSomeBusinessLogic()
        {
            Console.WriteLine("Depending strategy");
            List<string> data = new List<string> { "a" , "b", "c"};
            _Strategy.doAlgorithm(data);
        }
    }
}
