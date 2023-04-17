using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메서드 호출1");
            Thread.Sleep(1000);
            Console.WriteLine("메서드 호출2");
            Thread.Sleep(6000);
            Console.WriteLine("메서드 호출3");
        }
    }
}