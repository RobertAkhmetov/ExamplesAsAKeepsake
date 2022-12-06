using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DoOperation(5, 4, Add);         // 9
            DoOperation(5, 4, Subtract);    // 1
            DoOperation(5, 4, Multiply);    // 20
            Console.Read();
        }

        static void DoOperation(int a, int b, Operation op)
        {
            Console.WriteLine(op(a, b));
        }
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;

        delegate int Operation(int x, int y);
    }
}
