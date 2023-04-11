using System;

namespace lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Product<int> warAndPeace = new Product<int>("Война и Мир", "Толстой Л. Н.", 1869, 1300);
            Product<string> demon = new Product<string>("Демон", "Лермонтов М. Ю.", "1839", 352);

            warAndPeace.printBook();
            Console.WriteLine();

            demon.printBook();
            Console.WriteLine();
            
            

            User<int> mihail = new User<int>(7358340, "grenJu732");
            User<string> elena = new User<string>("elen_023N","tvurbom89");

            Cheque<int, int> cheque1 = new Cheque<int, int>(mihail, warAndPeace);
            Cheque<string, string> cheque2 = new Cheque<string, string>(elena, demon);

           
            cheque1.printInfo();
            Console.WriteLine();

            cheque2.printInfo();
            Console.WriteLine();

            cheque1.printUser();
            Console.WriteLine();
            cheque1.printBook();
            
        }
    }

    interface IPublishingHouse
    {
        string name { get; set; }
        string autor { get; set; }
        void printName();
        void printAutor();
        
    }

    interface IBook<B> : IPublishingHouse
    {
        B date { get; set; }
        int list { get; set; }
        void printBook();
        void printDateRealise();
        void printList();
       
        
    }
    class Product<B> : IBook<B>
    {
        public string name { get; set; }
        public B date { get; set; }
        public string autor { get; set; }
        public int list { get; set; }

        public Product(string name, string autor, B date, int list)
        {
            this.name = name;
            this.autor = autor;
            this.date = date;
            this.list = list;
        } 

        public void printBook()
        {
            Console.WriteLine($"Название книги: \"{name}\"\nАвтор: {autor}\nДата выпуска: {date}\nКол-во страниц: {list}");
        }
        
        public void printAutor()
        {
            Console.WriteLine($"Автор: {autor}");
        }

        public void printDateRealise()
        {
            Console.WriteLine($"Дата выпуска: {date}");
        }

        public void printList()
        {
            Console.WriteLine($"Кол-во страниц: {list}");
        }

        public void printName()
        {
            Console.WriteLine($"Название книги: \"{name}\"");
        }
    }
    interface IUser<T>
    {
        T login { get; set; }
        string password { get; set; }
        void printUser();
       
    }
    class User<T> : IUser<T>
    {
       
        public T login { get ; set; }
        public string password { get; set; }
        public User(T login, string password)
        {
            
            this.login = login;
            this.password = password;
        }

        public void printUser()
        {
            Console.WriteLine($"Логин:{login}\nПароль: {password}");
        }

      
    }
    class Cheque<T, B> : IUser<T>, IBook<B>
    {
        public T login { get; set ; }
        public string password { get; set; }
        public B date { get ; set ; }
        public int list { get ; set ; }
        public string name { get; set ; }
        public string autor { get; set; }

        public IUser<T> user;
        public IBook<B> book;

        public Cheque(IUser<T> user, IBook<B> book)
        {
            this.user = user;
            this.book = book;
        }

        public void printInfo()
        {
            Console.WriteLine($"Пользователь:{user.login}  купил книгу \"{book.name}\"");

        }

    
        public void printName()
        {
            Console.WriteLine(book.name);
        }
        public void printAutor()
        {
            Console.WriteLine(book.autor);
        }

        public void printDateRealise()
        {
            Console.WriteLine(book.date);
        }

        public void printList()
        {
            Console.WriteLine(book.list);
        }

        public void printBook()
        {
            Console.WriteLine($"Название книги: \"{book.name}\"\nАвтор: {book.autor}\nДата выпуска: {book.date}\nКол-во страниц: {book.list}");
        }

        public void printUser()
        {
            Console.WriteLine($"Логин:{user.login}\nПароль: {user.password}");
        }

        


    }


}
