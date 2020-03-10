using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Program Kalkulator";

        Console.Write("Input nilai a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Input nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
        Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
        Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
        Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

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