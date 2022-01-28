using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public interface ICard
    {
        string Transfer();
    }

    public class MasterCard : ICard
    {
        public string Transfer()
        {
            return "Funds were transferred by Mastercard";
        }
    }
    public class Visa : ICard
    {
        public string Transfer()
        {
            return "Funds were transferred by Visa";
        }
    }
}
