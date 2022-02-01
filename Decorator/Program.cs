using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var usrhlp = new UserHelp();
            AuthHelpDecorator authD = new AuthHelpDecorator(usrhlp);
            ShoppingHelpDecorator shopD = new ShoppingHelpDecorator(usrhlp);
            DeliveryHelpDecorator delD = new DeliveryHelpDecorator(usrhlp);

            Console.WriteLine(authD.GetUserHelp() + "\n" + shopD.GetUserHelp() + "\n" + delD.GetUserHelp());
        }
    }
}