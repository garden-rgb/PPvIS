using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IAirplanes:IAirTransport
    {
        public double EngineCounts { get; set; }
        public string TypeOfEngine { get; set; }
    }
}
