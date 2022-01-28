using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var visaP = new VisaPaymentSystem();
            Console.WriteLine(visaP.TransferDetails());
            var masterCardP = new MasterCardPaymentSystem();
            Console.WriteLine(masterCardP.TransferDetails());
        }
    }
}