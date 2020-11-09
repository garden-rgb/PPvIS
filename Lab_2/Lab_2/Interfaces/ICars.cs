using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    interface ICars:ILandTransport
    {
        protected string carType { get; set; }
        protected string engineType { get; set; }
        public void setEngineType(string engineType);
        public void setCarType(string carType);
    }
}
