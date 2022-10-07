using System;

namespace BubbleShort
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variabel int untuk menyiapkan banyaknya data pada array
        private int n;
       
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data uang disimpan pada array
            while(true)
            {
                Console.Write("Masukan banyaknya elemen pada Arra: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("Masukan elemen Array");
            Console.WriteLine("---------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++) 
            {
                Console.Write("<" + (i +1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);

            }
            Console.WriteLine("");
        }
    }
}
