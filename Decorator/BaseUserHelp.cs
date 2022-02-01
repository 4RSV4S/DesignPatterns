using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BaseUserHelp
    {
        public abstract string GetUserHelp();
    }

    class UserHelp : BaseUserHelp
    {
        public override string GetUserHelp()
        {
            return "Some user help";
        }
    }
}
