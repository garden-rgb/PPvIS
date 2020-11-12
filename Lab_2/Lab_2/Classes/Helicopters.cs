using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс наследник вертолётов
    /// </summary>
    class Helicopters:AirTransport,IHelicopters
    {
        private double _screwCount;
        private string _classification;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Helicopters()
        {
            _screwCount = 3;
            _classification = "Civil";
        }
        /// <summary>
        /// Свойство для чтения и записи количества винтов
        /// </summary>
        public double ScrewCount
        {
            get => _screwCount;
            set => _screwCount = value;
        }
        /// <summary>
        /// Свойство для чтения и записи классификации
        /// </summary>
        public string Classification
        {
            get => _classification;
            set => _classification = value;
        }
    }
}
