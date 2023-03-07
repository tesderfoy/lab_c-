using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Horse horse = new Horse("Элина", 18, "конюшне", "пиво");
            Cat cat = new Cat("Хюрэм", 2, "лечебнице", "рыбу");

            Vetenar vetenar = new Vetenar();
            vetenar.treatAnimal(horse);


            horse.makeEat();
            horse.makeSleep();
            horse.makeNoise();

            vetenar.treatAnimal(cat);
        
        }
    }

    class Animal
    {
       public string food;
       public string location;

        public Animal(string location, string food)
        {
            this.location = location;
            this.food = food;
            
        }


        public virtual void makeNoise()
        {
            Console.Write("Животное ");
        }
        public virtual void makeEat()
        {
            Console.WriteLine(" ест " + food);
        }
        public virtual void makeSleep()
        {
            Console.WriteLine(" спит в " + location);
        }
    }
    class Dog : Animal
    {
        public string name;
        public int age;
        string song = "рычит";
        string type = "Собака";

        

        
        public Dog(string name, int age, string location, string food) : base(location, food)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get; set; }

        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine(name + " "+ song);
        }

        public override void makeEat()
        {
            Console.Write(type + " " + name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(type + " " + name);
            base.makeSleep();
        }

    }
    class Cat : Animal
    {
        public string name;
        public int age;
        string song = "мявукает";
        string type = "Кошка";

        
        public Cat(string name, int age, string location, string food) : base(location, food)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get; set; }
        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine(name + " " + song);
        }


        public override void makeEat()
        {
            Console.Write(type + " " + name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(type + " " + name);
            base.makeSleep();
        }

    }
    class Horse : Animal
    {

        public string name;
        public int age;
        string song = "фырчит";
        string type = "Лошадь";
       

       

        public Horse(string name, int age, string location, string food) : base(location, food)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get; set; }


        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine(name + " " + song);
        }

        public override void makeEat()
        {
            Console.Write(type + " " + name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(type + " " + name);
            base.makeSleep();
        }
    }

   class Vetenar
   {
       public void treatAnimal(Animal animal)
       {
            Console.WriteLine("Животное ест " + animal.food + " в " + animal.location);
       }
   }
}
