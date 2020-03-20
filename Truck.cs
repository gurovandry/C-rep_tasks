using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace Tusk2CSH
{
    /// <summary>
    /// Класс тягочей, наследован от абстракного кдасса транспорт
    /// </summary>
    [Serializable]
    public class Truck : Transport
    {
        /// <summary>
        /// Переменная, отображающая наличие прицепа
        /// </summary>
        bool Trailer { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="marc"> сторка марки </param>
        /// <param name="num"> строка номера </param>
        /// <param name="speed"> строка скорости </param>
        /// <param name="weigh_abl"> строка грузоподъёмности</param>
        /// <param name="cycle"> наличие прицепа </param>
        public Truck(string marc, string num, string speed, string weigh_abl, bool trailer)
            : base(marc, num, speed, weigh_abl)
        {
            Marc = marc;
            Num = num;
            Speed = speed;
            if (trailer == false)
                Weigh_abl = weigh_abl;
            else
                Weigh_abl = Convert.ToString(Convert.ToInt32(weigh_abl)*2);
            Trailer = trailer;
        }

        public Truck()
        {

        }

        /// <summary>
        /// Метод вывода характеристик транспорта в консоль
        /// </summary>
        public void Display_Info()
        {
            Display();
            Console.WriteLine("The car's carrying capacity is: " + Weigh_abl + ",");
            if (Trailer == false)
                Console.WriteLine("There is no trailer.");
            else
                Console.WriteLine("There is a trailer.");
        }
    }
}
