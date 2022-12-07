using System;

namespace ConsoleApp6
{
    class Program
    {
        class EnteredLetters
        {
            public delegate void LettersHandler(string message);
            public event LettersHandler Notify;
            public string enteredResult = "abc";

            public EnteredLetters()
            {
                Notify += showEvent1;
                Notify += delegate     //добавим так же анонимный делегат
                {
                    Console.WriteLine("анонимный делегат");
                };
            }
            public void AddLetter(string newLet)
            {
                enteredResult += newLet;
                if (enteredResult == "abcd")
                    Notify?.Invoke("теперь это abcd");
            }

            public void showEvent1(string message) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"сообщение по событию 1 {enteredResult}: {message}");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            EnteredLetters entLet = new EnteredLetters();

            if (Console.ReadLine() == "d")
                entLet.AddLetter("d");
            Console.Read();
        }
    }
}
