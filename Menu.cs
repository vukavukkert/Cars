using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Menu
    {

        private static Car[] cars = new Car[0];
        public static void CarMenu(ref int num)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Добро пожаловать в меню, введите цифры от 1 до 4, что бы выбрать нужную услугу! \n Добавить машину: 1 \n Найти машину: 2 \n Отобразить информацию о машине: 3 \n Выход : 4");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1: AddCar( ref cars); break;
                case 2: FindCar(ref cars); break;
                case 3: Console.WriteLine("Введите порядок в машины списке:");
                    int order = int.Parse(Console.ReadLine());
                    CarInfo(cars, order); break;
            }
        }

        public static void CarInfo(Car[] cars, int order)
        {
            if (order > cars.Length)
            {
                Console.WriteLine("Такой машины нет");
            }
            cars[order].Display();
        }

        public static void FindCar(ref Car[] cars)
        {
            Console.WriteLine("Введите номер машины");
            string number = Console.ReadLine();
            int index = 0;
            bool found = false;
            foreach (Car car in cars)
            {
                if (car.number == number)
                {
                    found = true;
                    car.Display();
                    Console.WriteLine($"Положение в списке: {index}");
                    break;
                }
                index++;
            }
            if (found == false) Console.WriteLine("Не смогли найти");
        }

        public static void AddCar(ref Car[] cars)
        {
            Car[] addcar = new Car[cars.Length + 1];
            cars.CopyTo(addcar, 0);
            cars = addcar;
            Console.WriteLine("Введите параметры новой машины:");

            Console.WriteLine("Марка:");
            string mark = Console.ReadLine();
            Console.WriteLine("Модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string colour = Console.ReadLine();
            Console.WriteLine("Номер:");
            string number = Console.ReadLine();
            Car newCar = new Car(colour, model, mark, number);
            cars[^1] = newCar;
        }
    }
}
