using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели"); 
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите время");
            int time = Convert.ToInt32(Console.ReadLine());

            PrintInfo(day, time);
            
           
        }

        static void PrintInfo(int day, int a)
        {
            switch (day)
            {
                case 1:
                    Console.Write($"Сейчас {Day.Понедельник}, ") ;
                    break;
                case 2:
                    Console.Write($"Сейчас {Day.Вторник}, ");
                    break;
                case 3:
                    Console.Write($"Сейчас {Day.Среда}, ");
                    break;
                case 4:
                    Console.Write($"Сейчас {Day.Четверг}, ");
                    break;
                case 5:
                    Console.Write($"Сейчас {Day.Пятница}, ");
                    break;
                case 6:
                    Console.Write($"Сейчас {Day.Суббота}, ");
                    break;
                case 7:
                    Console.Write($"Сейчас {Day.Воскресенье}, ");
                    break;

                default:
                    Console.WriteLine("Неверно введен день недели");
                    break;

            }

            if(a>=7 && a<= 12)
            {
                Console.WriteLine(Time.Утро);

            }
            else if (a >= 13 && a <= 18)
            {
                Console.WriteLine(Time.День);
            }
            else if (a >= 19 && a <= 23)
            {
                Console.WriteLine(Time.Вечер);
            }

            else if (a >= 0 && a <= 6)
            {
                Console.WriteLine(Time.Ночь);
            }

            else
            {
                Console.WriteLine("Неверно введено время");
            }


        }

        enum Day
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        enum Time 
        {
            Утро,
            День,
            Вечер,
            Ночь
        }
    }
}
