using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tusk2CSH
{
    /// <summary>
    /// Класс мотоциклов, наследован от абстракного кдасса транспорт
    /// </summary>
    [Serializable]
    public class Motorcycle : Transport
    {
        /// <summary>
        /// Переменная, отображающая наличие коляски
        /// </summary>
        bool Cycle { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="marc"> сторка марки </param>
        /// <param name="num"> строка номера </param>
        /// <param name="speed"> строка скорости </param>
        /// <param name="weigh_abl"> строка грузоподъёмности</param>
        /// <param name="cycle"> наличие коляски </param>
        public Motorcycle(string marc, string num, string speed, string weigh_abl, bool cycle)
            : base(marc, num, speed, weigh_abl)
        {
            Marc = marc;
            Num = num;
            Speed = speed;
            if (cycle == false)
                Weigh_abl = "0";
            else
                Weigh_abl = weigh_abl;
            Cycle = cycle;
        }

        public Motorcycle()
        {

        }

        /// <summary>
        /// Метод вывода характеристик транспорта в консоль
        /// </summary>
        public void Display_Info()
        {
            Display();
            Console.WriteLine("The car's carrying capacity is: " + Weigh_abl + ",");
            if (Cycle == false)
                Console.WriteLine("There is no passenger carriage.");
            else
                Console.WriteLine("There is a passenger carriage."); 
        }
    }
}
