using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IWatchBuilder
    {
        void BuildClockFace();
        void BuildWatchBand(string bandType);
        void BuildWatchCase(string caseMaterial);
        void BuildSmartFunctions();

    }
    public class Director
    {
        private IWatchBuilder _builder;

        public IWatchBuilder Builder
        {
            set { _builder = value; }
        }
        public void BuildCheapAnalogWatch()
        {
            this._builder.BuildClockFace();
            this._builder.BuildWatchBand("Leatherette band");
            this._builder.BuildWatchCase("Stainless steel case");
            this._builder.BuildSmartFunctions();
        }
        public void BuildExpensiveAnalogWatch()
        {
            this._builder.BuildClockFace();
            this._builder.BuildWatchBand("Leather band");
            this._builder.BuildWatchCase("Golden case");
            this._builder.BuildSmartFunctions();
        }
        public void BuildCheapDigitalWatch()
        {
            this._builder.BuildClockFace();
            this._builder.BuildWatchBand("Leatherette band");
            this._builder.BuildWatchCase("Stainless steel case");
            this._builder.BuildSmartFunctions();
        }
        public void BuildExpensiveDigitalWatch()
        {
            this._builder.BuildClockFace();
            this._builder.BuildWatchBand("Leather band");
            this._builder.BuildWatchCase("Golden case");
            this._builder.BuildSmartFunctions();
        }
    }

    
}
