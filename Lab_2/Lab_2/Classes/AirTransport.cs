using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс наследник воздушного транспорта
    /// </summary>
    public class AirTransport:Transport,IAirTransport
    {
        private int _maxCapacity;
        /// <summary>
        /// Конструктор
        /// </summary>
        public AirTransport()
        {
            _maxCapacity = 0;
        }
        /// <summary>
        /// Свойство для чтения и записи максимальной грузоподъемности
        /// </summary>
        public int maxCapacity
        {
            get => _maxCapacity;
            
            set => _maxCapacity = value; 
        }
    }
}
