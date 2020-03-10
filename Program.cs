using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Program Kalkulator";

        Console.WriteLine("Pilihan menu kalkulator : \n");
        Console.WriteLine("1. penjumlahan\n2.pengurangan\n3.perkalian\n4.pembagian");
        Console.WriteLine();
        
        Console.Write("input nomor menu [1..4] : ");
        int pilih = int.Parse(Console.ReadLine());

        Console.Write("Input nilai a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Input nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        switch(pilih)
        {
            case 1:
                Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
            break;
            case 2:
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            break;
            case 3:
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            break;
            case 4:
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            break;
            default:
                Console.WriteLine("opsi tidak tersedia..");
                
            break;
        }
        Console.WriteLine();
        Console.WriteLine("tekan sembarang key untuk keluar...");
        Console.ReadKey();
        
    }

    static int penjumlahan(int a, int b)
    {
        return a + b;
    }

    static int pengurangan(int a, int b)
    {
        return a - b;
    }

    static int perkalian(int a, int b)
    {
        return a * b;
    }

    static int pembagian(int a, int b)
    {
        return a / b;
    }
}