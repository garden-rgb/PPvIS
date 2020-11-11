using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface ITransport
    {
        public int MaxSpeed { get; set; }

        public int MaxLoad { get; set; }

    }
}
