using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface ILandTransport:ITransport
    {
        public int Horsepower { get; set; }
        public string EngineType { get; set; }
    }
}
