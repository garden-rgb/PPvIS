using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IWaterTransport:ITransport
    {
        public string Displacement { get; set; }
        public double CarryingCapacity { get; set; }
    }
}
