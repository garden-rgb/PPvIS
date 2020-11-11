using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    /// <summary>
    /// Класс наследник наземного транспорта
    /// </summary>
    public class LandTransport:Transport,ILandTransport
    {
        private int _horsePower;
        
        private string _engineType;
        /// <summary>
        /// Конструктор
        /// </summary>
        public LandTransport()
        {
            _horsePower = 150;
            _engineType = "Disel";
        }
        /// <summary>
        ///  Поле для чтения и записи лошадиных сил
        /// </summary>
        public int Horsepower
        {
            get => _horsePower;
            
            set => _horsePower=value;
        }
        /// <summary>
        /// Поле для чтения и записи вида двигателя
        /// </summary>
        public string EngineType
        {
            get => _engineType;
            
            set => _engineType = value;
        }
    }
}
