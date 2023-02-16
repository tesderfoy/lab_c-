using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.WriteLine("Введите X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            int n = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x) > 1 | n < 0)
            {
                Console.WriteLine("Введите другие значения");
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    int step = 2 * i + 1;
                    sum = sum + (Math.Pow(x, step))/ (step);

                }
                Console.WriteLine("Ответ: " + sum);
            }

           
        }
    }
}
