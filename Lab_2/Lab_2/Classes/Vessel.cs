using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс-наследник морских судов
    /// </summary>
    public class Vessel:WaterTransport,IVessel
    {
        private double _maxCarrying;

        public Vessel()
        {
            _maxCarrying = 12000;
        }
        /// <summary>
        /// Свойство максимальной вместимости судна
        /// </summary>
        public double MaxCarrying
        {
            get => _maxCarrying;
            set => _maxCarrying = value;
        }
    }
}
