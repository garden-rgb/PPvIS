using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
   /// <summary>
   /// Класс наследник машин
   /// </summary>
    public class Cars:LandTransport,ICars
    {
        private string _carType;
        private string _carModel;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Cars()
        {
            _carType = "Passenger car";
            _carModel = "Ford";
        }
        /// <summary>
        /// Поле для чтения и записи типа машины
        /// </summary>
        public string CarType
        {
            get => _carType;
            set => _carType = value;
        }
        /// <summary>
        /// Поле для чтения и записи модели машины
        /// </summary>
        public string CarModel
        {
            get => _carModel;
            set => _carModel = value;
        }
    }
}
