using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс наследник поездов
    /// </summary>
    public class Trains:LandTransport,ITrains
    {
        private double _thrust;
        private string _typeOfenergy;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Trains()
        {
            _thrust = 2000;
            _typeOfenergy = "Steam";
        }
        /// <summary>
        /// Поле для чтения и записи силы тяги
        /// </summary>
        public double Thrust
        {
            get => _thrust;
            set => _thrust = value;
        }
        /// <summary>
        /// Поле для чтения и записи вида используемой энергии
        /// </summary>
        public string TypeOfEnergy
        {
            get => _typeOfenergy;
            set => _typeOfenergy = value;
        }
    }
}
