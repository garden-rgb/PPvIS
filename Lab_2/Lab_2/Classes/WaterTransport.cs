using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class WaterTransport:Transport,IWaterTransport
    {
        private string _displacement;
        private double _carryingCapacity;
        public WaterTransport()
        {
            _displacement = "Standart";
            _carryingCapacity = 1500;
        }
        public string Displacement
        {
            get => _displacement;
            
            set => _displacement = value;
        }
        public double CarryingCapacity
        {
            get => _carryingCapacity;
            
            set => _carryingCapacity = value;
        }
    }
}
