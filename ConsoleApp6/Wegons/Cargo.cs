using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Wegons
{
    internal class Cargo : Wegon
    {
        string content;
        public Cargo()
        {
            
                content = "|^^^^|";
            
            
        }
        public string getContent()
        {
            return this.content;
        }
    }
}
