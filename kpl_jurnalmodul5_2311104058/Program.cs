using System;

public class Penjumlahan
{
    // Method generic untuk menjumlahkan tiga angka
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic temp = angka1;
        temp += angka2;
        temp += angka3;
        return temp;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Masukkan NIM (8 atau 10 digit): ");
        string nim = Console.ReadLine();

        if (nim.Length == 8 || nim.Length == 10)
        {
            int angka1 = int.Parse(nim.Substring(0, 2));
            int angka2 = int.Parse(nim.Substring(2, 2));
            int angka3 = int.Parse(nim.Substring(4, 2));

            Penjumlahan penjumlahan = new Penjumlahan();
            int hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan: {hasil}");
        }
        else
        {
            Console.WriteLine("NIM harus 8 atau 10 digit!");
        }
    }
}
