using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Transport:ITransport
    {
        private int _maxSpeed;
        private int _maxLoad;
        public Transport()
        {
             _maxSpeed=0;
             _maxLoad = 0;
        }
        int MaxSpeed()
        {
             _maxSpeed = 0;
        }
    }
}
