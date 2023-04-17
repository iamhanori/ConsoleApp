using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메서드 호출1");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서드 호출2");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("메서드 호출3");
        }
    }
}