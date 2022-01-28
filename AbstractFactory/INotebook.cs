using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface INotebook
    {
        public string ToSetupDesktopApp();
        public string ToInteractWithPhone(IPhone phone);
    }

    public class AppleMacbook : INotebook
    {
        public string ToSetupDesktopApp()
        {
            return "The desktop application has been installed running .dmg file";
        }
        public string ToInteractWithPhone(IPhone phone)
        {
            if (phone is AppleIPhone)
            {
                var result = phone.ToDownloadApp();
                return $"{result} Files has been sent via AirDrop";
            }
            else return "Devices are incompatible.";
        } 
    }
    public class GoogleChromebook : INotebook
    {
        public string ToSetupDesktopApp()
        {
            return "The desktop application has been installed running .apk file";
        }
        public string ToInteractWithPhone(IPhone phone)
        {
            if (phone is GooglePixel)
            {
                var result = phone.ToDownloadApp();
                return $"{result} Chromebook has been unlocked using Google Pixel.";
            }
            else return "Devices are incompatible.";
        }
    }
    public class MicrosoftSurfaceLaptop : INotebook
    {
        public string ToSetupDesktopApp()
        {
            return "The desktop application has been installed running .exe file";
        }
        public string ToInteractWithPhone(IPhone phone)
        {
            if (phone is MicrosoftLumia)
            {
                var result = phone.ToDownloadApp();
                return $"{result} The mobile call has been answered with Microsoft Surface Laptop.";
            }
            else return "Devices are incompatible.";
        }
    }
}
