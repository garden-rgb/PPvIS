using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface ITrains:ILandTransport
    {
       public double Thrust { get; set; }
       public string TypeOfEnergy { get; set; }
    }
}
