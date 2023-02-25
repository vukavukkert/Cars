using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
        public string colour;
        public string model;
        public string mark;
        public string number;
   
        
        public Car(string colour = "неизвестно", string model = "неизвестно", string mark = "неизвестно", string number = "неизвестно")
        {
            this.colour = colour;
            this.model = model;
            this.mark = mark;
            this.number = number;
        }

        public void Display()
        {
            Console.WriteLine($" Марка: {mark}, Модель : {model}, Цвет: {colour}, Номер: {number}");
        }
    }
}
