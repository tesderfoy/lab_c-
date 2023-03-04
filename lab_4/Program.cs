using System;
using System.Linq;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = {
                new Student("Христосов", "Д.Ф.", "20ФТ21", new int[] { 5, 5, 4, 5, 3 }),
                new Student("Собаковы", "Т.Л.", "19ИТ22", new int[] { 2, 3, 4, 3, 2 }),
                new Student("Мезенцева", "А.К.", "22ФТ8", new int[] { 4, 3, 4, 5, 3 }),
                new Student("Егоров", "В.Н.", "21ИТ21", new int[] { 3, 3, 3, 3, 2 }),
                new Student("Григорьев", "Л.В.", "22ФТ41", new int[] { 4, 3, 3, 5, 4 }),
                new Student("Митяева", "Э.А.", "22ФТ9", new int[] { 2, 2, 2, 2, 3 }),
                new Student("Хасанова", "П.О.", "21ФТ21", new int[] { 5, 5, 4, 5, 4 })
            };

            var result = student.OrderBy(n => n.MGrade);
            foreach (Student st in result)
            {
                st.PrintStudent();
            }

            
            
        }
    }

   public struct Student
    {
        string lastName;
        string initials;
        string group;
        int[] grade;
        double mGrade;

        public Student(string lastName, string initials, string group, int[] grade)
        {
            this.lastName = lastName;
            this.initials = initials;
            this.group = group;
            this.grade = grade;
            mGrade = grade.Average();
        }
        public double MGrade
        {
            get
            {
                return mGrade;
            }
        }
        public void PrintStudent()
        {
            Console.WriteLine("ФИО: " +lastName+" "+initials + " группа: " + group + " ср. балл " + mGrade);
        }
    }
}
