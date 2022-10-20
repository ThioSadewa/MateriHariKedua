using System;

namespace Loops{
    class Program
    {
        static void Main(string[] args) {
            for (int a = 0; a <= 1000000; a = a + 1) {
                Console.WriteLine("Pengulangan for ke: {0}", a);
            }
            Console.ReadLine();
        }
    }
}

