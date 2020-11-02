using Lab_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IVessel : IWaterTransport
    {
        public double maxCarrying { get; set; }
        public void setMaxCarrying(double maxCarrying);
    }
}
