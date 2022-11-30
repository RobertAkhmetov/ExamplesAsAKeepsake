using System;

using System.Threading; //Именно это пространство имен поддерживает многопоточность

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func); //Создаем новый объект потока (Thread)

            myThread.IsBackground = true;
            myThread.Start(); //запускаем поток

            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 1 выводит " + i);
                Thread.Sleep(0);
            }

            Console.Read(); //Приостановим основной поток

        }

        //Функция запускаемая из другого потока
        static void func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 2 выводит " + i);
                Thread.Sleep(0);
            }
        }
    }
}