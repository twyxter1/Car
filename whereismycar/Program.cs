using System;

namespace whereismycar
{
    class Program
    {
        class Car
        {
            public string mark;
            public string model;
            public string color;
            public int odometer;
            public int fuel;
            public string regno;

            public void PrintCarInfo()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odometer: {odometer}");
                Console.WriteLine($"Fuel: {fuel}");
                Console.WriteLine($"Registration number: {regno}");
            }

        }

        class racing_car : Car
        {
            public racing_car(string _mark, string _model, string _color, string _regno)
            {
                mark = _mark;
                model = _model;
                color = _color;
                odometer = 0;
                fuel = 60;
                regno = _regno;
            }

            public void OneLap()
            {
                odometer += 100;
                fuel -= 5;
            }

            static void Main(string[] args)
            {
                racing_car Audi = new racing_car("Audi", "Quattro", "White", "213ERT");
                Audi.PrintCarInfo();

                while (Audi.fuel > 0)
                {
                    Audi.OneLap();
                }

                Audi.PrintCarInfo();
            }
        }
    }
}

