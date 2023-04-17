using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static readonly int SnackStateTotal = 3;
        private const int SnackState1 = 0;
        private const int SnackState2 = 1;
        private const int SnackState3 = 2;
        private static readonly int SnackMoveCount = 50;
        private static readonly int SnackRow = 5;
        private static readonly int SnackSleepTime = 1000;


        static void Main(string[] args)
        {
            int x = SnackState1;
            while (x<SnackMoveCount)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnackRow);
                
                switch(x % SnackStateTotal)
                {
                    case SnackState1:
                        Console.WriteLine("__@");
                        break;
                    case SnackState2:
                        Console.WriteLine("_^@");
                        break;
                    case SnackState3:
                        Console.WriteLine("^_@");
                        break;
                }
                Thread.Sleep(SnackSleepTime);
                x++;
            }
        }
    }
}