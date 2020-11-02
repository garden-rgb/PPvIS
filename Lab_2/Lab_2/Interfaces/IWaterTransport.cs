using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.Interfaces
{
    public interface IWaterTransport:ITransport
    {
        protected int displacement { get; set; }
        public void setDisplacement(int displacement);
    }
}
