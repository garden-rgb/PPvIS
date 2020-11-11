using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IHelicopters:IAirTransport
    {
        public double ScrewCount { get; set; }
        public string Classification { get; set; }
    }
}
