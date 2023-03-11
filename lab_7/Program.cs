using System;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hynday hynday = new Hynday("Hynday", 2, 3, 4);
            hynday.Print();
            Console.WriteLine(hynday.speed);

            Boing boing = new Boing("Boing", 20, 12, 800);
            boing.Print();

            Aurora aurora = new Aurora("Aurora", 100, 200, 1000);
            aurora.Print();

            aurora.SpeedInf();
            

        }



        abstract class Transport
        {
            public abstract void SpeedInf();
            public abstract void LoadCapasityInf();
            public abstract void DistanceInf();

        }
        abstract class Car : Transport
        {
            protected Car(double speed, double loadCapacity, double distance)
            {
                this.speed = speed;
                this.loadCapacity = loadCapacity;
                this.distance = distance;
            }

            public double speed { get; set; }
            public double loadCapacity { get; set; }
            public double distance { get; set; }

            public override void SpeedInf()
            {
                Console.WriteLine($"Скорость: {speed}");
            }
            public override void LoadCapasityInf()
            {
                Console.WriteLine($"Грузоподъемность: {loadCapacity}");

            }
            public override void DistanceInf()
            {
                Console.WriteLine($"Дистанция: {distance}");
            }

        }
        abstract class Ship : Transport
        {
            protected Ship(double speed, double loadCapacity, double distance)
            {
                this.speed = speed;
                this.loadCapacity = loadCapacity;
                this.distance = distance;
            }

            public double speed { get; set; }
            public double loadCapacity { get; set; }
            public double distance { get; set; }

            public override void SpeedInf()
            {
                Console.WriteLine($"Скорость: {speed}");
            }
            public override void LoadCapasityInf()
            {
                Console.WriteLine($"Грузоподъемность: {loadCapacity}");

            }
            public override void DistanceInf()
            {
                Console.WriteLine($"Дистанция: {distance}");
            }

        }
        abstract class AirShip : Transport
        {
            protected AirShip(double speed, double loadCapacity, double distance)
            {
                this.speed = speed;
                this.loadCapacity = loadCapacity;
                this.distance = distance;
            }

            public double speed { get; set; }
            public double loadCapacity { get; set; }
            public double distance { get; set; }

            public override void  SpeedInf()
            {
                Console.WriteLine($"Скорость: {speed}") ;
            }
            public override void LoadCapasityInf()
            {
                Console.WriteLine($"Грузоподъемность: {loadCapacity}");

            }
            public override void DistanceInf()
            {
                Console.WriteLine($"Дистанция: {distance}");
            }

        }


        class Hynday : Car
        {

            public string mark { get; set; }

            public Hynday(string mark, double speed, double loadCapacity, double distance) : base(speed, loadCapacity, distance)
            {
                this.mark = mark;
            }
            public override void SpeedInf()
            {
                base.SpeedInf();
            }
            public override void LoadCapasityInf()
            {

                base.LoadCapasityInf();
            }
            public override void DistanceInf()
            {
                base.DistanceInf();
            }
            public void Print()
            {
                Console.WriteLine($"{mark}, грузоподьемностью в {loadCapacity} тонны может проехать {distance} км");
            }

        }
        class Boing : AirShip
        {
            public string mark { get; set; }

            public Boing(string mark, double speed, double loadCapacity, double distance) : base(speed, loadCapacity, distance)
            {
                this.mark = mark;
            }
            public override void SpeedInf()
            {
                base.SpeedInf();
            }
            public override void LoadCapasityInf()
            {

                base.LoadCapasityInf();
            }
            public override void DistanceInf()
            {
                base.DistanceInf();
            }
            public void Print()
            {
                Console.WriteLine($"{mark}, грузоподьемностью в {loadCapacity} тонны может проехать {distance} км");
            }

        }

        class Aurora : Ship
        {
            public string mark { get; set; }

            public Aurora(string mark, double speed, double loadCapacity, double distance) : base(speed, loadCapacity, distance)
            {
                this.mark = mark;
            }
            public override void SpeedInf()
            {
                base.SpeedInf();
            }
            public override void LoadCapasityInf()
            {

                base.LoadCapasityInf();
            }
            public override void DistanceInf()
            {
                base.DistanceInf();
            }
            public void Print()
            {
                Console.WriteLine($"{mark}, грузоподьемностью в {loadCapacity} тонны может проехать {distance} км");
            }

        }

    }
}
    
