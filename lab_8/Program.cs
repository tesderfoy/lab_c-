using System;

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<int> masI = new Array<int>();
            Array<string> masS = new Array<string>();
            Array<double> masD = new Array<double>();

            masI.Add(1);
            masI.Add(2);
            masI.Add(13);
            masI.Add(4);
            masI.Add(5);
            masI.Add(6);
            masI.Delete(3);
            masI.Print();
            masI.lenghtArray();
            Console.WriteLine();

            masS.Add("12");
            masS.Add("24");
            masS.Add("35");
            masS.Add("47");
            masS.Add("78");
            masS.Delete(2);
            masS.Print();
            masS.lenghtArray();
            Console.WriteLine();


            masD.Add(2.4);
            masD.Add(1.4);
            masD.Add(8.9);
            masD.Add(2.5);
            masD.Add(1.7);
            masD.Delete(5);
            masD.Print();
            masD.lenghtArray();
            masD.indexArray(2);
            Console.WriteLine();




        }
    }
    public class Array<T>
    {
        T[] array;
        public  Array()
        {
            array = new T[0];
        }
        public void Add(T element)
        {
            T[] array2 = new T[array.Length + 1];
            for(int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array.Length] = element;
            array = array2;
        }
        public void  Delete(int index)
        {
            index = index - 1;
            if (index >= array.Length)
            {
                Console.WriteLine("Выход за предел массива");
            }
            else
            {
                
                T[] array2 = new T[array.Length - 1];

                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        array2[j] = array[i];
                        j++;
                    }
                }
                array = array2;
            }
           
        }

        public void indexArray(int a)
        { if (a > array.Length|a< 0)
            {
                Console.WriteLine("Выход за предел массива");
            }
            else
            {
                Console.WriteLine($"Под индексом {a} находится элемент {array[a]}");
            }
        }

        public void lenghtArray()
        {
            Console.WriteLine($"Длинна массива: { array.Length}");
        }
        public void Print()
        {
           foreach (object a in array)
           {
                Console.Write(a + " ");
           }
            Console.WriteLine();
        }
    }
}


