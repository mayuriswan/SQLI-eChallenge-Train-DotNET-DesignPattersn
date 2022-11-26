using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Wegons
{
    internal class EmptyCargo:Wegon
    {
        string content;
        public EmptyCargo()
        {

            content = "|____|";


        }
        public string getContent()
        {
            return this.content;
        }
    }
}
