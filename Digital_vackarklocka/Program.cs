using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            AlarmClock ac = new AlarmClock();
            Console.WriteLine("test 1");
           

            //Test 2
            ac = new AlarmClock(9, 42);
            Console.WriteLine("test 2");
            


            //Test 3
            ac = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("test 3");
           

            //Test 4
            ac = new AlarmClock(23, 58, 7, 35);
            Console.WriteLine("test 4");
            Run(ac, 13);
           
            //Test 5
            ac = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("test 5");
            Run(ac, 6);
        
            

            //Test 6
            ac = new AlarmClock();
            Console.WriteLine("test 6");
           
          
        

       }

       //Metoder

        private static void Run(AlarmClock ac, int minutes)
        { 
        

         for (int i = 0; i < minutes; i++)
         {

             if (ac.TickTock())
             {
                 Console.BackgroundColor = ConsoleColor.Blue;
                 Console.WriteLine("{0}BEEP! BEEP! BEEP!", ac);
                 Console.ResetColor(); 

             }
             else
             {
                 Console.WriteLine(ac);
             }
         }
     
        }

        private static void ViewErrorMessage(string message)
        {
            //Skriver ut felmeddelande.
        }

        private static void ViewTestHeader(string header)
        {

        }
    }
}
