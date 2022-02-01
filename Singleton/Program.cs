using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = UserHelp.GetInstance();
            var h2 = UserHelp.GetInstance();
            bool areEqual = ReferenceEquals(h1, h2);

            if(areEqual == true)
            {
                Console.WriteLine("Singleton class 'UserHelp' works, both variables references refer to the same object.");
                Console.WriteLine(UserHelp.GetHelp());
            }
            else if(areEqual == false)
            {
                Console.WriteLine("Singleton class 'UserHelp' failed, both variables references refer to the different objects.");
            }
        }
    }
}