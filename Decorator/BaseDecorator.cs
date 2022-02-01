using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class BaseDecorator : BaseUserHelp
    {
        protected BaseUserHelp _usrhlp;

        public BaseDecorator(BaseUserHelp usrhlp)
        {
            _usrhlp = usrhlp;
        }
        public override string GetUserHelp()
        {
            if (_usrhlp != null)
            {
                return _usrhlp.GetUserHelp();
            }
            else
            {
                return string.Empty;
            }
        }
    }
    class AuthHelpDecorator : BaseDecorator
    {
        public AuthHelpDecorator(BaseUserHelp usrhlp) : base(usrhlp)
        {
        }
        public override string GetUserHelp()
        {
            return $"{base.GetUserHelp()}\nSome authentification help";
        }
    }
    class ShoppingHelpDecorator : BaseDecorator
    {
        public ShoppingHelpDecorator(BaseUserHelp comp) : base(comp)
        {
        }

        public override string GetUserHelp()
        {
            return $"{base.GetUserHelp()}\nSome shopping help";
        }
    }
    class DeliveryHelpDecorator : BaseDecorator
    {
        public DeliveryHelpDecorator(BaseUserHelp comp) : base(comp)
        {
        }

        public override string GetUserHelp()
        {
            return $"{base.GetUserHelp()}\nSome delivery help";
        }
    }
}
