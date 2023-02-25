using Cars;
using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Car machina = new Car("Red");

int num = 0;
while (num != 4)
{
    Menu.CarMenu( ref num);
}

