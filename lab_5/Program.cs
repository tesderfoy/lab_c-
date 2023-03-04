using System;

namespace lab_5
{
    using College;
    using Library;
    class Program
    {

        static void Main(string[] args)
        {
            Student[] student = {
            
                new Student("Егоров", "В.Н.", "21ИТ21", 21),
                new Student("Григорьев", "Л.В.", "22ФТ41", 19 ),
                new Student("Митяева", "Э.А.", "22ФТ9",  20)
            };

            Reader[] readers =
            {

                new Reader("Егоров В.Н.","2aQ88J","Факультет информатики", "22.01. 2002", "89969617427"),
                new Reader("Григорьев Л.В", "9sK54H","Химический факультет", "02.02. 2004", "89969619533"),
                new Reader("Митяева Э.А.", "3dL89M","Факультет экономики", "04.03. 2003", "88005353535")
            };


            readers[0].returnBook(1);
            readers[0].returnBook("\"Война и мир\"");
            readers[2].takeBook("\"Гроза \", \"Обломов\" ");
            readers[1].returnBook(2);




        }
    }
}

namespace College
{
    class Student
    {
        string lastName;
        string initials;
        string group;
        private int  age;


        public double Age
        {
            get
            {
                return age;
            }
        }

        public Student(string lastName, string initials, string group, int age)
        {
            this.lastName = lastName;
            this.initials = initials;
            this.group = group;
            this.age = age;
        }
    }

}

namespace Library
{
    class Reader
    {
        private string fio;
        string ticketNumber;
        string faculty;
        private string dateOfbirth;
        string telephoneNumber;

        public  Reader(string fio, string ticketNumber, string faculty, string dateOfbirth, string telephoneNumber)
        {
            this.fio = fio;
            this.ticketNumber = ticketNumber;
            this.faculty = faculty;
            this.telephoneNumber = telephoneNumber;
        }

        public string DateOfBirtth
        {
            get
            {
                return dateOfbirth;
            }
        }
        public string Fio
        {
            get
            {
                return fio;
            }
        }


        public void takeBook(int a)
        {
            Console.WriteLine($"{fio} взял книг: {a} ");
        }
        public void takeBook(string  a)
        {
            Console.WriteLine($"{fio} взял книги: {a} ");
        }
        public void returnBook(int a)
        {
            Console.WriteLine($"{fio} вернул книг: {a} ");
        }
        public void returnBook(string  a)
        {
            Console.WriteLine($"{fio} вернул книги: {a} ");
        }
    }

    
}
