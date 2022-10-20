using System;
namespace DecisionMaking {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=========================================");
            Console.WriteLine("Silahkan Input Grade, A,B,C,D,E,F");
            Console.Write("Masukkan Grade Anda: ");
            char grade= Convert.ToChar (Console.ReadLine());
        switch (grade) {
            case 'A' :
                Console.WriteLine("Pintar Sekali");
                break;
            case 'B' :
                Console.WriteLine("Pintar Saja");
                break;
            case 'C' :
                Console.WriteLine("Lumayan Pintar");
                break;
            case 'D' :
                Console.WriteLine("Perlu Belajar");
                break;
            case 'E' :
                Console.WriteLine("Sangat Perlu Belajar Lagi");
                break;
            case 'F' :
                Console.WriteLine("Level Akurat, Perlu Belajar Ekstra");
                break;
            }
        }
    }
}
