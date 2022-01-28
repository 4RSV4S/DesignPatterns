using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public abstract class PaymentSystem
    {
        public abstract ICard FactoryMethod();

        public string TransferDetails()
        {
            var card = FactoryMethod();
            var result = "Transfer was made. " + card.Transfer();
            return result;
        }
    }

    public class MasterCardPaymentSystem : PaymentSystem
    {
        public override ICard FactoryMethod()
        {
            return new MasterCard();
        }
    }

    public class VisaPaymentSystem : PaymentSystem
    {
        public override ICard FactoryMethod()
        {
            return new Visa();
        }
    }
}
