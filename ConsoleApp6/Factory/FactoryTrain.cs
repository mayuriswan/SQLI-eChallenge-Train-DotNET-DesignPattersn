using ConsoleApp6.Wegons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Factory
{
    internal class FactoryTrain : IFactoryTrain
    {
        LinkedList<Wegon> Train;
        public static FactoryTrain Instance = null;
        private FactoryTrain()
        {

        }

        public static FactoryTrain getInstant()
        {
            if (Instance == null) {
                Instance = new FactoryTrain();
            }
            return Instance;
        }



        public LinkedList<Wegon> CreateTrain(string structure)
        {
           Train= new LinkedList<Wegon>();
            for(int i =0 ; i < structure.Length; i++)
            {
                switch (structure.ElementAt(i))
                {
                    case 'H':
                       if( i == structure.Length - 1)
                        {
                            Train.AddLast(new Head(true));
                        }
                        else
                        {
                            Train.AddLast(new Head(false));
                        }
                
                        break;
                    case  'P':
                            Train.AddLast(new Pas()); break;
                    case 'R':
                        Train.AddLast(new Rest()); break;
                    case 'C':
                        Train.AddLast(new EmptyCargo()); break;
                }
                if (i != structure.Length - 1)
                {
                    Train.AddLast(new Connector());
                }
               
            }
            

            return Train;
        }
    } }
