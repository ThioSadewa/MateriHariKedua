using System;  
class Program  
{  
    static void Main(string[] args) 
{
    int  Angka, Jumlah = 0;
    Console.Write("\n\n");
    Console.WriteLine("Penambahan 10 angka pertama pengulangan: ");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Angka Pertama Mulai Dari :");
     for (Angka = 1; Angka <= 10; Angka++)
    {
        Jumlah = Jumlah + Angka;
        Console.Write("{0} ",Angka);   
    }
    Console.Write("\nHasil penambahan : {0}\n", Jumlah);
    Console.Write("\n\n");
  }
}