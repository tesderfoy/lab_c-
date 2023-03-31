using System;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Day prinntDay = () =>
            {   
                count++;
                switch (count)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        break;

                    case 2:
                        Console.WriteLine("Вторник");
                        break;

                    case 3:
                        Console.WriteLine("Среда");
                        break;
                    case 4:
                        Console.WriteLine("Четверг");
                        break;
                    case 5:
                        Console.WriteLine("Пятница");
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        break;
                    case 7:
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        count = 1;
                        Console.WriteLine("Понедельник");
                        break;
                }

            };

            prinntDay(); // Pn 
            prinntDay(); // vt
            prinntDay(); // sr
            prinntDay(); // cht
            prinntDay(); // pt
            prinntDay();// sybb
            prinntDay(); // voscr
            prinntDay(); //pn
            prinntDay(); // vt
            prinntDay();  // sr
            prinntDay(); // cht
            prinntDay(); // pt
            prinntDay();// sybb
            prinntDay(); // voscr
            prinntDay(); //pn
            prinntDay(); // vt
            prinntDay();  // sr
        }
    }


    delegate void Day();
}
