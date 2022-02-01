using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var aBuilder = new AnalogWatchBuilder();
            director.Builder = aBuilder;

            Console.WriteLine("Cheap analog watch:");
            director.BuildCheapAnalogWatch();
            Console.WriteLine(aBuilder.GetWatch().ListParts());

            Console.WriteLine("Premium analog watch:");
            director.BuildExpensiveAnalogWatch();
            Console.WriteLine(aBuilder.GetWatch().ListParts());

            var dBuilder = new DigitalWatchBuilder();
            director.Builder = dBuilder;

            Console.WriteLine("Cheap digital watch:");
            director.BuildCheapDigitalWatch();
            Console.WriteLine(dBuilder.GetWatch().ListParts());
            
            Console.WriteLine("Premium digital watch:");
            director.BuildExpensiveDigitalWatch();
            Console.WriteLine(dBuilder.GetWatch().ListParts());
        }
    }
}
