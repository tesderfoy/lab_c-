using System;

namespace lab_9
{

    class Program
    {
        static void Main(string[] args)
        {

            Log<string> log = new Log<string>();
            Password password = new Password();
            log.Add("Login");
            password.Add("Psa");

            log.Print();
            password.Print();

            
        }
        public class Array<T>
        {
            T[] array;
            public Array()
            {
                array = new T[0];
            }
            public void Add(T element)
            {
                T[] array2 = new T[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = array[i];
                }
                array2[array.Length] = element;
                array = array2;
            }
            public void Delete(int index)
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
            {
                if (a > array.Length | a < 0)
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
        public class Log<T> : Array<T>
        {
            
            
            public Log() 
            {
                
            }
        }
        public class Password : Array<string>
        {
            
            public Password()
            {
                
            }
        }
    }
}
