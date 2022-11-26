using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Wegons
{
    internal class Rest : Wegon
    {
        string content;
        public Rest()
        {
            content = "|hThT|";
        }
        public string getContent()
        {
            return this.content;
        }
    }
}
