using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace Tusk2CSH
{
    /// <summary>
    /// Абстрактный класс транспорта
    /// </summary>
    
    [Serializable]
    public abstract class Transport
    {
        /// <summary>
        /// Марка машины
        /// </summary>
        public string Marc { get; set; }
        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// Скорость автомобиля
        /// </summary>
        public string Speed { get; set; }
        /// <summary>
        /// Грузоподъёмность автомобиля
        /// </summary>
        public string Weigh_abl { get; set; }

        /// <summary>
        /// Конструктор абстрактоного класса транспорта
        /// </summary>
        /// <param name="marc"> строка марки </param>
        /// <param name="num"> строка номера </param>
        /// <param name="speed"> строка скорости</param>
        /// <param name="weigh_abl"> строка грузоподъёмности </param>
        public Transport(string marc, string num, string speed, string weigh_abl)
        {
            Marc = marc;
            Num = num;
            Speed = speed;
        }

        public Transport()
        {

        }


        /// <summary>
        /// Метод вывода характеристик транспорта в консоль
        /// </summary>
        public void Display()
        {
            Console.WriteLine("The car brand is: "+ Marc);
            Console.WriteLine("The car number is: " + Num);
            Console.WriteLine("The car speed is: " + Speed);
        }


    }
}
