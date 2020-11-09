using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface ITrains:ILandTransport
    {
       protected double thrust { get; set; }
       protected string typeOfEnergy { get; set; }
       public void setThrust(double thrust);
       public void setTypeOfEnergy(string typeOfEnergy);
    }
}
