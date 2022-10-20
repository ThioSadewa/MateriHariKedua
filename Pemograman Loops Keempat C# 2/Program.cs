using System;
namespace perulangan_foreach{
    class Program {
        static void Main(string[] args) {
            string [] bulan = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"};
            foreach (string urutan in bulan) {
                Console.WriteLine("Bulan " + urutan);
            }
            Console.ReadLine();
            
            {
                
            }
        }
    }
}

