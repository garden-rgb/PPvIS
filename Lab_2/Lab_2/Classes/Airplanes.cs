using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс наследник самолётов
    /// </summary>
    public class Airplanes:AirTransport,IAirplanes
    {
        private double _engineCounts;
        private string _typeOfEngine;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Airplanes()
        {
            _engineCounts = 4;
            _typeOfEngine = "Rocket engine";
        }
        /// <summary>
        /// Свойство для чтения и записи количества двигателей
        /// </summary>
        public double EngineCounts
        {
            get => _engineCounts;
            set => _engineCounts = value;
        }
        /// <summary>
        /// Свойство для чтения и записи вида двигателя
        /// </summary>
        public string TypeOfEngine
        {
            get => _typeOfEngine;
            
            set => _typeOfEngine = value;
        }
    }
}
