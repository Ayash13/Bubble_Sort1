﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort1
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20 
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data apda array
        private int[] n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("Array dapat mempunyai maksimal 20 elemen");
            }
            Console.WriteLine("");
            Console.WriteLine("====================");
            Console.WriteLine("Masukan elemen array");
            Console.WriteLine("====================");

            //Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++) ;
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("=================================");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");

        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)//For n-1 passes
            {
                //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) //Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}