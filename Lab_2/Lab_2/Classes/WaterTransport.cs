using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс водного транспорта
    /// </summary>
    public class WaterTransport:Transport,IWaterTransport
    {
        private string _displacement;
        private double _carryingCapacity;
        public WaterTransport()
        {
            _displacement = "Standart";
            _carryingCapacity = 1500;
        }
        /// <summary>
        /// Свойство водоизмещения
        /// </summary>
        public string Displacement
        {
            get => _displacement;
            
            set => _displacement = value;
        }
        /// <summary>
        /// Свойство грузоподъемности
        /// </summary>
        public double CarryingCapacity
        {
            get => _carryingCapacity;
            
            set => _carryingCapacity = value;
        }
    }
}
