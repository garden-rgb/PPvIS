using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.Interfaces
{
    public interface ILandTransport:ITransport
    {
        protected int horsepower { get; set; }
        protected int engineСapacity { get; set; }
        public void setHorsepower(int horsepower);
        public void setEngineCapacity(int engineCapacity);
    }
}
