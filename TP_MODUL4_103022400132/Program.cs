using System;

namespace TP_MODUL4_103022400132
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kpos = new KodePos();
            Console.Write("Masukkan Kode Pos: ");
            string inputUser = Console.ReadLine();
            Console.WriteLine($"Kelurahan: {kpos.getKelurahan(inputUser)}");

            Console.WriteLine("----------------------------");
            DoorMachine pintu = new DoorMachine();
            while (true)
            {
                Console.Write("\nBeri perintah (BukaPintu / KunciPintu / Keluar): ");
                string input = Console.ReadLine();
                if (input == "Keluar") break;
                pintu.PerubahanState(input);
            }
            Console.WriteLine("Program selesai.");
        }
    }
}