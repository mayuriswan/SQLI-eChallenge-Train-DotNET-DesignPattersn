using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Wegons
{
    internal class Head : Wegon
    {
        string content;
        public Head( bool Rev) {
            if(Rev == true)
            {
                this.content = "HHHH>";
            }
            else
            {
                this.content = "<HHHH";
            }
        }
        public string getContent()
        {
           return content;
        }
    }
}
