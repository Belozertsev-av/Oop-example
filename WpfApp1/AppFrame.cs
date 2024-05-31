using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class AppFrame
    {
        public static Frame appFrame;

        static Cars car1 = new Cars()
        {
            Id = 1,
            carNumber = "BMW",
            type = "превышение скорости",
            cost = 5000,
            status = "Не оплачен"
        };
        static Cars car2 = new Cars()
        {
            Id = 2,
            carNumber = "Mersedes",
            type = "Не правильная парковка",
            cost = 2000,
            status = "Не оплачен"
        };
        static Cars car3 = new Cars()
        {
            Id = 3,
            carNumber = "Lada granta",
            type = "Пересечение двойной сплошной",
            cost = 100500,
            status = "Оплачен"
        };
        static Cars car4 = new Cars()
        {
            Id = 4,
            carNumber = "SAAB",
            type = "Говняный цвет машины",
            cost = 500,
            status = "Оплачен"
        };
        static Cars car5 = new Cars()
        {
            Id = 5,
            carNumber = "Волга",
            type = "Колесо отлетело и разбило лобовуху Land Cruiser",
            cost = 1_000_000,
            status = "Не оплачен"
        };

        public static List<Cars> cars = new List<Cars>() { car1, car2, car3, car4, car5 };
    }
}
