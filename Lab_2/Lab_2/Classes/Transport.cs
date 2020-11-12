using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Родительский класс Транспорта
    /// </summary>
    public class Transport:ITransport
    {
        private int _maxSpeed;
        private int _maxLoad;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public Transport()
        {
             _maxSpeed=0;
             _maxLoad = 0;
        }
        /// <summary>
        /// Свойство для чтения и записи максимальной скорости
        /// </summary>
        public int MaxSpeed
        {
            get => _maxSpeed;

            set => _maxSpeed = value;
        }
        /// <summary>
        /// Свойство для чтения и записи максимальной грузоподъёмности
        /// </summary>
        public int MaxLoad
        {
            get => _maxLoad;
            
            set => _maxLoad = value;
        }

    }
}
