using ConsoleApp6.Factory;
using ConsoleApp6.Wegons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Train
    {
        FactoryTrain Fact = FactoryTrain.getInstant();
        LinkedList<Wegon> Wegons ;
        public Train(string structure)
        {
          Wegons = Fact.CreateTrain(structure);
        }
        
        public string print() {
            string s="";
            for(int i =0; i < Wegons.Count; i++)
            {
                s += Wegons.ElementAt(i).getContent();
            }
            return s;
        }
        public void DetachEnd()
        {
            Wegons.RemoveLast();
            Wegons.RemoveLast();
        }
        public void DeatachFirst()
        {
            Wegons.RemoveFirst();
            Wegons.RemoveFirst();
        }
        public bool fill()
        {
            int i = 0;
            foreach (Wegon we in Wegons)
            {
                if(we is EmptyCargo)
                {
                    Wegons.Find(we).Value = new Cargo();
                    
                    return true;
                }
            }
            return false;
        }
    }
}
