using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(12.328);
            Console.WriteLine("Hello World!");
            Beep();
        }

        static void Beep()
        {
            Console.Beep(15000, 100000);
        }
    }
}
