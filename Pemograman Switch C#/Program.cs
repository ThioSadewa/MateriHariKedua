using System;
namespace Perulangan_foreach
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Selamat Datang Di Server");
            Console.Write("Masukkan Password : ");
            String pass = Console.ReadLine();
            switch (pass) {
                case "Mis":
                Console.Clear();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Selamat Anda Masuk Ke Server 1");
                Console.WriteLine("===================================================================================");
                break;
                default:
                Console.Clear();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Anda Tidak Dapat Masuk");
                Console.WriteLine("===================================================================================");
                break;
            }
            Console.ReadLine();
        }
    }
}
