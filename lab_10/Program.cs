using System;
using System.Collections.Generic;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage();
            Car tesla = new Car("Tesla");
            garage.carCollection.Add(tesla);
            garage.carCollection.Add(new Car("BMW"));
            garage.carCollection.Add(new Car("Audi"));
            garage.carCollection.Add(new Car("Mersedec"));
            garage.carCollection.Add(new Car("Lada"));
            garage.carCollection.Add(new Car("Nisan"));

            WashD washDq;
            washDq = new Washer().wash;

            for(int i = 0; i < garage.carCollection.Count; i++)
            {
                washDq.Invoke((garage.carCollection[i]));
            }
        }
    }

    class Car
    {
        public string name;
        public Car(string name)
        {
            this.name = name;
        }
    }

    class Garage
    {
        public List<Car> carCollection;

        public Garage()
        {
            carCollection = new List<Car>();
        }
    }
    class Washer
    {
        public void wash(Car car)
        {
            Console.WriteLine($"{car.name} моется");
        }
    }
    delegate void WashD(Car car);





}

