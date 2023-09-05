using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class ConcreteStrategyB : Strategy
    {
        public void doAlgorithm(List<string> data)
        {
            Console.WriteLine("Unsort data strategy b");
            Console.WriteLine(data);
        }
    }
}
