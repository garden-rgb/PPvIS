using Lab_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IVessel : IWaterTransport
    {
        public double MaxCarrying { get; set; }
    }
}
