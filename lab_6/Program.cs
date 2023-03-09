using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Horse horse = new Horse("Элина", 18, "конюшне", "сено");
            Cat cat = new Cat("Хюрэм", 2, "лечебнице", "рыпку");

            Vetenar vetenar = new Vetenar();
            vetenar.treatAnimal(horse);


            horse.makeEat();
            horse.makeSleep();
            horse.makeNoise();

            vetenar.treatAnimal(cat);
            cat.makeNoise();
        
        }
    }

    class Animal
    {
       public string food;
       public string location;
       public string type;

        public Animal(string location, string food, string type)
        {
            this.location = location;
            this.food = food;
            this.type = type;
        }


        public virtual void makeNoise()
        {
            Console.WriteLine($"{type} издает звук");
        }
        public virtual void makeEat()
        {
            Console.WriteLine($" ест {food}");
        }
        public virtual void makeSleep()
        {
            Console.WriteLine($" спит в {location}");
        }
    }
    class Dog : Animal
    {
        public string name { get; set;}
        public int age;
        string song = "рычит";
        
        public Dog(string name, int age, string location, string food, string type = "собака") : base(location, food, type)
        {
            this.name = name;
            this.age = age;
            
        }
        

        public override void makeNoise()
        {
            Console.WriteLine($"{name} {song}");
        }
        

        public override void makeEat()
        {
            Console.Write(name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(name);
            base.makeSleep();
        }

    }
    class Cat : Animal
    {
        public string name;
        public int age;
        string song = "мявукает";
       


        public Cat(string name, int age, string location, string food, string type="кошка") : base(location, food, type)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get; set; }
        public override void makeNoise()
        {
            
            Console.WriteLine($"{name}  {song}");
        }


        public override void makeEat()
        {
            Console.Write(name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(name);
            base.makeSleep();
        }

    }
    class Horse : Animal
    {

        public string name;
        public int age;
        string song = "фырчит";
   




        public Horse(string name, int age, string location, string food, string type = "лошадь") : base(location, food, type)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get; set; }


        public override void makeNoise()
        {
            
            Console.WriteLine($"{name}  {song}");
            
        }

        public override void makeEat()
        {
            Console.Write(name);
            base.makeEat();
        }
        public override void makeSleep()
        {
            Console.Write(name);
            base.makeSleep();
        }
    }

   class Vetenar
   {
       public void treatAnimal(Animal animal)
       {
            Console.WriteLine($"{animal.type} ест   {animal.food}  в  {animal.location}");
       }
   }
}
