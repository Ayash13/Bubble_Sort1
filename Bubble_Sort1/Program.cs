using System;
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
    }
}