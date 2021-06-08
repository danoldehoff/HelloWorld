using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Constants.Number = 100;
            Console.WriteLine(Constants.Number);
            Console.WriteLine("Hello World!");
            Beep();
        }

        private static void Beep()
        {
            Console.Beep(15000, 100000);
        }
    }
}
