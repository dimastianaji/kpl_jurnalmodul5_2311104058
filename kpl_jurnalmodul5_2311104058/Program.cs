using System;
using System.Collections.Generic;

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

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    // Method untuk menambahkan data baru dan waktu input dari user
    public void AddNewDataFromUser()
    {
        Console.Write("Masukkan data baru: ");
        string inputData = Console.ReadLine();

        Console.Write("Masukkan waktu input (format: yyyy-MM-dd HH:mm:ss): ");
        string inputDate = Console.ReadLine();

        try
        {
            T data = (T)Convert.ChangeType(inputData, typeof(T));
            DateTime date = DateTime.ParseExact(inputDate, "yyyy-MM-dd HH:mm:ss", null);
            storedData.Add(data);
            inputDates.Add(date);
            Console.WriteLine("Data dan waktu berhasil ditambahkan!\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Input tidak valid: {e.Message}\n");
        }
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
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
            Console.WriteLine($"Hasil penjumlahan: {hasil}\n");

            SimpleDataBase<int> database = new SimpleDataBase<int>();
            database.AddNewDataFromUser();
            database.AddNewDataFromUser();
            database.AddNewDataFromUser();
            database.PrintAllData();
        }
        else
        {
            Console.WriteLine("NIM harus 8 atau 10 digit!");
        }
    }
}
//Dimastian Aji WIbowo