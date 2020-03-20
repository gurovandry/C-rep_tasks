using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tusk2CSH
    
{   /// <summary>
    /// Класс пассажирского транспорта, наследован от абстракного кдасса транспорт
    /// </summary>
    [Serializable]
    public class PassengerCar : Transport
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="marc"> строка марки </param>
        /// <param name="num"> строка номера </param>
        /// <param name="speed"> строка скорости</param>
        public PassengerCar(string marc, string num, string speed, string weigh_abl)
            : base(marc, num, speed, weigh_abl)
        {
            Marc = marc;
            Num = num;
            Speed = speed;
            Weigh_abl = weigh_abl;
        }

        public PassengerCar()
        {

        }

        /// <summary>
        /// Метод вывода характеристик транспорта в консоль
        /// </summary>
        public void Display_Info()
        {
            Display();
            Console.WriteLine("The car's carrying capacity is: "+ Weigh_abl+".");
        }

        
    }
}
