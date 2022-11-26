using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public  static void test(string Entry , string Sortie)
        {
            if (Entry == Sortie)
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("FAILED");
            };
        }
        //Test1
         public static void passengerTrain()
        {
            
            Train train = new Train("HPP");
            test("<HHHH::|OOOO|::|OOOO|" , train.print());
          

            
          
        }

        //@Test
    public static void restaurantTrain()
        {
            Train train = new Train("HPRP");
            test("<HHHH::|OOOO|::|hThT|::|OOOO|", train.print());
          

        }

        //@Test
    public static void doubleHeadedTrain()
        {
            Train train = new Train("HPRPH");
            test("<HHHH::|OOOO|::|hThT|::|OOOO|::HHHH>", train.print());
          
        }

        //@Test
    public static void  modifyTrain()
        {
            Train train = new Train("HPRPH");
            train.DetachEnd();
            test("<HHHH::|OOOO|::|hThT|::|OOOO|", train.print());
           

            train.DeatachFirst();
            test("|OOOO|::|hThT|::|OOOO|", train.print());

         
        }

        //@Test
    public static void cargoTrain()
        {
            Train train = new Train("HCCC");
            test("<HHHH::|____|::|____|::|____|", train.print());
            train.fill();
           test("<HHHH::|^^^^|::|____|::|____|", train.print());
            train.fill();
            test("<HHHH::|^^^^|::|^^^^|::|____|", train.print());
            train.fill();
           test("<HHHH::|^^^^|::|^^^^|::|^^^^|", train.print());
            if (!train.fill())
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        //@Test
    public static void mixedTrain()
        {
            Train train = new Train("HPCPC");
            test("<HHHH::|OOOO|::|____|::|OOOO|::|____|", train.print());
            train.fill();
            test("<HHHH::|OOOO|::|^^^^|::|OOOO|::|____|", train.print());
            train.fill();
            test("<HHHH::|OOOO|::|^^^^|::|OOOO|::|^^^^|", train.print());
            if (!train.fill())
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }
        static void Main(string[] args)
        {
            //test1
            passengerTrain();
            //Test 2
            restaurantTrain();
            //Test3
            doubleHeadedTrain();
            //Test 4
            modifyTrain();
            //Test 5
            cargoTrain();
            //Test 6
            mixedTrain();
            Console.ReadKey(true);

        }
    }
}
