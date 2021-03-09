using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
        awal:
            Console.Title = "Aplikasi Kalkulator";
            Console.WriteLine("Menu Kalkulator :");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");
            Console.WriteLine("Pilih Nomor Menu[1-4]:");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.Write("Input Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
            }
            else if (m == 2)
            {
                Console.Write("Input Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (m == 3)
            {
                Console.Write("Input Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }
            else if (m == 4)
            {
                Console.Write("Input Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, Menu yang Anda Pilih Tidak Tersedia\n");

            }

            Console.WriteLine("Apakah Anda Ingin Menggunakan Kalkulator Kembali? : Y/N");
            string pilih = Console.ReadLine();

            if (pilih == "Y" || pilih == "y")
            {
                Console.Clear();
                goto awal;
            }
            else


                Console.WriteLine("\nTekan Sembarang Tombol untuk Keluar");
            Console.ReadKey();

        }
        static int penambahan(int a, int b)
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
}
