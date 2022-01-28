using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFactory
    {
        IPhone CreatePhone();
        INotebook CreateNotebook();
    }
    public class AppleFactory : IFactory
    {
        public IPhone CreatePhone()
        {
            return new AppleIPhone();
        }
        public INotebook CreateNotebook()
        {
            return new AppleMacbook();
        }
    }
    public class GoogleFactory : IFactory
    {
        public IPhone CreatePhone()
        {
            return new GooglePixel();
        }
        public INotebook CreateNotebook()
        {
            return new GoogleChromebook();
        }
    }
    public class MicrosoftFactory : IFactory
    {
        public IPhone CreatePhone()
        {
            return new MicrosoftLumia();
        }
        public INotebook CreateNotebook()
        {
            return new MicrosoftSurfaceLaptop();
        }
    }


}
