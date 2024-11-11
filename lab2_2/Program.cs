namespace lab2_2
{

    using System;

    namespace VehicleExample
    {
        //базовый класс Vehicle
        public class Vehicle
        {
            public (double X, double Y) Coordinates { get; set; }
            public decimal Price { get; set; }
            public double Speed { get; set; }
            public int YearOfManufacture { get; set; }

            //конструктор
            public Vehicle((double X, double Y) coordinates, decimal price, double speed, int yearOfManufacture)
            {
                Coordinates = coordinates;
                Price = price;
                Speed = speed;
                YearOfManufacture = yearOfManufacture;
            }

            //метод для вывода информации о транспортном средстве
            public virtual void ShowInfo()
            {
                Console.WriteLine($"Coordinates: ({Coordinates.X}, {Coordinates.Y})");
                Console.WriteLine($"Price: {Price} $");
                Console.WriteLine($"Speed: {Speed} km/h");
                Console.WriteLine($"Year of Manufacture: {YearOfManufacture}");
            }
        }

        public class Plane : Vehicle
        {
            public double Height { get; set; }
            public int NumberOfPassengers { get; set; }

            public Plane((double X, double Y) coordinates, decimal price, double speed, int yearOfManufacture, double height, int numberOfPassengers)
                : base(coordinates, price, speed, yearOfManufacture)
            {
                Height = height;
                NumberOfPassengers = numberOfPassengers;
            }

            //переопределение метода ShowInfo
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Height: {Height} meters");
                Console.WriteLine($"Number of Passengers: {NumberOfPassengers}");
            }
        }

        public class Car : Vehicle
        {
            public Car((double X, double Y) coordinates, decimal price, double speed, int yearOfManufacture)
                : base(coordinates, price, speed, yearOfManufacture)
            {
            }

            //переопределение метода ShowInfo
            public override void ShowInfo()
            {
                base.ShowInfo();
            }
        }

        public class Ship : Vehicle
        {
            public int NumberOfPassengers { get; set; }
            public string PortOfRegistry { get; set; }

            public Ship((double X, double Y) coordinates, decimal price, double speed, int yearOfManufacture, int numberOfPassengers, string portOfRegistry)
                : base(coordinates, price, speed, yearOfManufacture)
            {
                NumberOfPassengers = numberOfPassengers;
                PortOfRegistry = portOfRegistry;
            }

            //переопределение метода ShowInfo
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Number of Passengers: {NumberOfPassengers}");
                Console.WriteLine($"Port of Registry: {PortOfRegistry}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //экземпляры транспортных средств
                Vehicle plane = new Plane((34.05, -118.25), 2000000m, 900, 2020, 12000, 150);
                Vehicle car = new Car((40.71, -74.01), 30000m, 150, 2023);
                Vehicle ship = new Ship((51.51, -0.12), 500000m, 30, 2015, 500, "London");

                //выводим информацию о транспортных средствах
                Console.WriteLine("Plane Information:");
                plane.ShowInfo();
                Console.WriteLine();

                Console.WriteLine("Car Information:");
                car.ShowInfo();
                Console.WriteLine();

                Console.WriteLine("Ship Information:");
                ship.ShowInfo();
                Console.WriteLine();
            }
        }
    }


}
