using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        string[] daftarKelurahan = {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        Console.WriteLine("╔══════════════════════╦════════════╗");
        Console.WriteLine("║ Kelurahan            ║  Kode Pos  ║");
        Console.WriteLine("╠══════════════════════╬════════════╣");

        foreach (string kelurahan in daftarKelurahan)
        {
            string hasil = kodePos.GetKodePos(kelurahan);
            Console.WriteLine($"║ {kelurahan,-20} ║  {hasil,-9} ║");
        }

        Console.WriteLine("╚══════════════════════╩════════════╝");
        Console.ReadKey();
    }
}
