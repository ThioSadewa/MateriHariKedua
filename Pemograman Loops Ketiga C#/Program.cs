using System;

namespace Loops {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            do {
                Console.WriteLine("Pengulangan do dan While Ke: {0} ", a);
                a = a + 1;
            }
            while (a < 20);
            Console.ReadLine();

        }
    }
}
