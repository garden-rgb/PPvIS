using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IAirplanes:IAirTransport
    {
        protected double engineCounts { get; set; }
        public void setEngineCounts(double engineCounts);
    }
}
