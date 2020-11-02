using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public interface ITransport
    {
        protected int MaxSpeed { get; set; }

        protected int MaxLoad { get; set; }

        public void SetMaxSpeed(int maxSpeed);
        public void SetMaxLoad(int maxLoad);

    }
}
