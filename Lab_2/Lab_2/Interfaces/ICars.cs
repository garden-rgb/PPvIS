using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    interface ICars:ILandTransport
    {
        public string CarType { get; set; }
        public string CarModel { get; set; }
    }
}
