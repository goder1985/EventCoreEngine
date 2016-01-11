using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventCore.Events;
using EventCore;
using EventCore.Events.DefaultEvents;
using EventCore.Events.EventsArgs;
namespace TestEventCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ECore ecore=new ECore())
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Run Engine");
                ecore.run();

           
           
             Console.ReadKey();
             Console.WriteLine("*****************************************************");
             Console.WriteLine("Stop enginee");
            ecore.Stop();
            Console.ReadKey();
            }
        }

      
    }
}
