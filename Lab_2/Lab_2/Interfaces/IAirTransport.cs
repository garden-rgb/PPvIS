using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IAirTransport:ITransport
    {
        public int maxCapacity { get; set; }

    }
}
