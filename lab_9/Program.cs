using System;

namespace lab_9
{

    class Program
    {
        static void Main(string[] args)
        {
            User oleg = new("Oleg.2@gmail.com","qazjfu8Nund");
            User marta = new("marta_killer.some@gmail.com", "difh3dwi8n");

            oleg.PrintUser();
            Console.WriteLine();
            marta.PrintUser();

            marta.logArray.lenghtArray();
            


        }
        public class Array<T>
        {
           public T[] array;
            public Array(T[] array)
            {
                this.array = array;
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

        public class User
        {
            string login { get; set; }
            string password { get; set; }
            public Log<string> logArray = new Log<string>();
            public Password passwordArray = new Password();

            public User(string login, string password)
            {
                this.login = login;
                this.password = password;
                logArray.Add(login);
                passwordArray.Add(password);
            }
            public void PrintUser()
            {
                Console.WriteLine("Логин:");
                logArray.Print();
                Console.WriteLine("Пароль:");
                passwordArray.Print();
            }


        }
        public class Log<T> : Array<T>
        {
            
            
            public Log(params T[] array) : base(array)
            {
                
            }
        }
        public class Password : Array<string>
        {
            
            public Password(params string[] array) : base(array)
            {
                
            }
        }
    }
}
