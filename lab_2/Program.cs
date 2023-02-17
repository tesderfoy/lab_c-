using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[size];
            Console.WriteLine("Введите элементы массива");
            for ( int j = 0;j < size; j++)
            {
                mas[j] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i< mas.Length; i++)
            {
                int index = i;
                int num = mas[i];

                while(index > 0 && num<mas[index - 1])
                {
                    mas[index] = mas[index - 1];
                    index--;
                }
                mas[index] = num;
            }
            Console.WriteLine("Отсортированный массив");
            foreach (int a in mas)
            {
                Console.WriteLine(a);
            }



        }



    }
}
