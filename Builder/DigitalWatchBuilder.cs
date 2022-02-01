using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DigitalWatchBuilder : IWatchBuilder
    {
        private Watch watch = new Watch();

        public DigitalWatchBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.watch = new Watch();
        }

        public void BuildClockFace()
        {
            this.watch.Add("Digital clock face");
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
            this.watch.Add("Smart functions");
        }

        public Watch GetWatch()
        {
            Watch result = this.watch;

            this.Reset();

            return result;
        }
    }
}
