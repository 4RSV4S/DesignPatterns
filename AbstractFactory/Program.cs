using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMethod(new AppleFactory());
            CustomerMethod(new GoogleFactory());
            CustomerMethod(new MicrosoftFactory());

            void CustomerMethod(IFactory someFactory)
            {
                var phone = someFactory.CreatePhone();
                var notebook = someFactory.CreateNotebook();

                Console.WriteLine(notebook.ToSetupDesktopApp());
                Console.WriteLine(notebook.ToInteractWithPhone(phone));
            }
        }
    }
}