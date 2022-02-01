using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class AnalogWatchBuilder : IWatchBuilder
    {
        private Watch watch = new Watch();

        public AnalogWatchBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.watch = new Watch();
        }

        public void BuildClockFace()
        {
            this.watch.Add("Analog clock face");
        }

        public void BuildWatchBand(string bandType)
        {
            this.watch.Add(bandType);
        }

        public void BuildWatchCase(string caseMaterial)
        {
            this.watch.Add(caseMaterial);
        }

        public void BuildSmartFunctions()
        {
            this.watch.Add("No smart functions");
        }

        public Watch GetWatch()
        {
            Watch result = this.watch;

            this.Reset();

            return result;
        }
    }
}
