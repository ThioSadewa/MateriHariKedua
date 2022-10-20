using System;

namespace Loops {
    class Program {
        static void Main(string[] args) {
            int a = 20;
            while (a > 0) {
                Console.WriteLine("Perulangan While Ke: {0}", a);
                a--;
            }
            Console.ReadLine();
        }

    }
}
