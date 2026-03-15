class Program
{
    static void Main(string[] args)
    {
        // KODEPOS 
        Console.WriteLine("=== Tabel Kode Pos ===\n");
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

        // DOORMACHINE
        Console.WriteLine("\n=== Simulasi DoorMachine ===\n");
        DoorMachine door = new DoorMachine();

        Console.WriteLine("-- Aksi: BukaPintu --");
        door.BukaPintu();

        Console.WriteLine("\n-- Aksi: KunciPintu --");
        door.KunciPintu();

        Console.WriteLine("\n-- Aksi: BukaPintu lagi --");
        door.BukaPintu();

        Console.ReadKey();
    }
}