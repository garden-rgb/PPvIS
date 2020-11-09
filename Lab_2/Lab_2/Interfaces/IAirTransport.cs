using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface IAirTransport:ITransport
    {
        protected int maxCapacity { get; set; }
        public void setMaxCapacity(int maxCapacity);

    }
}
