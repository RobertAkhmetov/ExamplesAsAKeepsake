using System;
using System.Text;

namespace ConsoleApp8
{
    static class StringBuilderCustom
    {
        public static int CharIndex(this StringBuilder sb, char c)
        {
            for(int i = 0; i< sb.Length; i++)
            {
                if (sb[i] == c)
                    return i;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("fsdsdf");
            Console.WriteLine(sb.CharIndex('f'));
            Console.Read();
        }
    }
}
