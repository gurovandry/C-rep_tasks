using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Tusk2CSH
{
    


    class Program
    {
        
        static void Main(string[] args)
        {

            XmlSerializer fmen_c = new XmlSerializer(typeof(PassengerCar));
            XmlSerializer fmen_m = new XmlSerializer(typeof(Motorcycle));
            XmlSerializer fmen_t = new XmlSerializer(typeof(Truck));
            StreamWriter fl = new StreamWriter(@"C:\Test\Xmlout.xml", true, System.Text.Encoding.Default);
            /// <summary>
            /// Считывание информаци о машинах из файда
            /// </summary>
            var sr = new StreamReader(@"C:\Test\cars\cars_list.txt");
            var n = Convert.ToInt32(sr.ReadLine());
            string[] result;
            string[] massive_out = { "," };
            /// <summary>
            /// Объявление списков для хранения данных о машин каждого типа
            /// </summary>
            List<PassengerCar> car_array = new List<PassengerCar>();
            List<Motorcycle> moto_array = new List<Motorcycle>();
            List<Truck> tr_array = new List<Truck>();
            string m_w;


            /// <summary>
            /// Вывод информации
            /// </summary>
            for (int i = 0; i < n; i++)
            {
                var line = sr.ReadLine();
                result = line.Split(massive_out, StringSplitOptions.RemoveEmptyEntries);
                var type = result[0];
                

                switch (type)
                {
                    /// <summary>
                    /// Ветвление для градации по типу автомобиля
                    /// </summary>
                    case "PassengerCar":
                        var car = new PassengerCar(result[1], result[2], result[3], result[4]);
                            Trace.WriteLine("Создан экземпляр класса PassengerCar");
                            Trace.Indent();
                        car.Display_Info();
                        fmen_c.Serialize(fl,car);
                            Trace.WriteLine("Вызван метод класса PassengerCar");
                            Trace.Indent();
                        Console.WriteLine();
                        car_array.Add(car);
                        break;

                    case "Motorcycle":
                        var motorcycle = new Motorcycle(result[1], result[2], result[3], result[4], Convert.ToBoolean(result[5]));
                            Trace.WriteLine("Создан экземпляр класса Motorcycle");
                            Trace.Indent();
                        motorcycle.Display_Info();
                        fmen_m.Serialize(fl, motorcycle);
                        Trace.WriteLine("Вызван метод класса Motorcycle");
                            Trace.Indent();
                        Console.WriteLine();
                        moto_array.Add(motorcycle);
                        break;

                    case "Truck":
                        var truc = new Truck(result[1], result[2], result[3], result[4], Convert.ToBoolean(result[5]));
                            Trace.WriteLine("Создан экземпляр класса Truck");
                            Trace.Indent();
                        truc.Display_Info();
                        fmen_t.Serialize(fl, truc);
                        Trace.WriteLine("Вызван метод класса Truck");
                            Trace.Indent();
                        Console.WriteLine();
                        tr_array.Add(truc);
                        break;
                }

            }
            /// <summary>
            /// Запрос на поиск машин с определенной грузоподъёмностью
            /// </summary>
            Console.WriteLine("Please, input your value of  car's carrying capacity: ");
            m_w = Console.ReadLine();
            Console.WriteLine("Cars for you: ");
            foreach (PassengerCar tr in car_array)
            {
                if (tr.Weigh_abl == m_w)
                {
                    tr.Display();
                    Trace.WriteLine("Вызван метод класса Motorcycle");
                    Trace.Indent();
                }
            }
            foreach (Motorcycle tr in moto_array)
            {
                {
                    tr.Display();
                    Trace.WriteLine("Вызван метод класса Motorcycle");
                    Trace.Indent();
                }
            }
            foreach (Truck tr in tr_array)
            {
                if (tr.Weigh_abl == m_w)
                {
                    tr.Display();
                    Trace.WriteLine("Вызван метод класса Truck");
                    Trace.Indent();
                }
            }
            Console.ReadKey();

        }
    }
}
