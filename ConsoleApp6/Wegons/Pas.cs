using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Wegons
{
    internal class Pas : Wegon
    {

        string content;
        public Pas()
        {
            content = "|OOOO|";
        }
        public string getContent()
        {
            return this.content;

        }
    }
}
