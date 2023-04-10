using System;

namespace lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account("Hello");
            Account ac2 = new Account("Hi");

            Message message = new Message();

            ac1.notify+= message.PrintMessageEvent;
            ac2.notify += message.PrintMessageEvent;

            ac1.useEvent();
            ac2.useEvent();

        }

    }
    class Account
    {
        public delegate void EventMessage(string name);
        public event EventMessage notify;

        string name;

        public Account (string name)
        {
            this.name = name;
        }
        public void useEvent()
        {
            notify?.Invoke(name);
        }
    }
    class Message
    {
        public void PrintMessageEvent(string name)
        {
            Console.WriteLine($"{name}");
        }
    }
}
