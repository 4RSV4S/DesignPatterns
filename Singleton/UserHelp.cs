using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class UserHelp
    {
        private UserHelp() { }

        private static UserHelp _instance;

        public static UserHelp GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserHelp();
            }
            return _instance;
        }

        public static string GetHelp()
        {
            return "Some user help";
        }
    }
}
