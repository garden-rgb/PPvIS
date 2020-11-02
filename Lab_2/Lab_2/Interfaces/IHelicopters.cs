using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.Interfaces
{
    public interface IHelicopters:IAirTransport
    {
        protected double screwCount { get; set; }
        protected string classification { get; set; }
        public void setScrewCount(double screwCount);
        public void setClassification(string classification);
    }
}
