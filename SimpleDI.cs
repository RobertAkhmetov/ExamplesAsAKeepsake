using System;

namespace ConsoleApp3
{

    interface ILogger
    {
        void Log(string message);
    }
    class Logger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }
    class Message
    {
        ILogger logger;
        public string Text { get; set; } = "";
        public Message(ILogger logger)
        {
            this.logger = logger;
        }
        public void Print() => logger.Log(Text);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Message mes = new Message(new Logger());
            mes.Text = "Hello World!";
            mes.Print();
            Console.Read();
        }
    }
}
