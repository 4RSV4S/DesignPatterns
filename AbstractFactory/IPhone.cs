using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IPhone
    {
        public string ToDownloadApp();
    }

    public class AppleIPhone : IPhone
    {
        public string ToDownloadApp()
        {
            return "The application has been downloaded from the Apple App Store.";
        }
    }
    public class GooglePixel : IPhone
    {
        public string ToDownloadApp()
        {
            return "The application has been downloaded from the Google Play Market.";
        }
    }
    public class MicrosoftLumia : IPhone
    {
        public string ToDownloadApp()
        {
            return "The application has been downloaded from the Microsoft Store.";
        }
    }
}
