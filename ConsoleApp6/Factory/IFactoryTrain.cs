using ConsoleApp6.Wegons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Factory
{
    internal interface IFactoryTrain
    {
        LinkedList<Wegon> CreateTrain(string structure);
    }
}
