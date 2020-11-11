using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Vessel:WaterTransport,IVessel
    {
        private double _maxCarrying;

        public Vessel()
        {
            _maxCarrying = 12000;
        }
        public double MaxCarrying
        {
            get => _maxCarrying;
            set => _maxCarrying = value;
        }
    }
}
