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
            AlarmClock ac = new AlarmClock();
            Console.WriteLine("test 1");
            Console.WriteLine(ac);

            ac = new AlarmClock(9, 42);
            Console.WriteLine("test 2");
            Console.WriteLine(ac);

            ac = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("test 3");
            Console.WriteLine(ac);

            ac = new AlarmClock(23, 58);
            Console.WriteLine("test 4");
            Console.WriteLine(ac);

            ac = new AlarmClock();
            Console.WriteLine("test 5");
            Console.WriteLine(ac);

            ac = new AlarmClock();
            Console.WriteLine("test 6");
            Console.WriteLine(ac);

            ac.TickTock();
       }

       //Metoder som 

        private static void Run(AlarmClock ac, int minutes)
        { 
         AlarmClock clock = new AlarmClock();   
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
