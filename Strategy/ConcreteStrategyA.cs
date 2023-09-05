using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class ConcreteStrategyA : Strategy
    {
        public void doAlgorithm(List<string> data)
        {
            Console.WriteLine("Sort array function A ...");
            Console.WriteLine(data);
        }
    }
}
