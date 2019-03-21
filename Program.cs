using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace tugas_sa
{
    class searching
    {
        static void Main()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Do something.
            //Deklarasi dan Inisiasi
            searching search = new searching();
            int[] array;
            int toSearch;
            //Menginput panjay array
            Console.Write("Input panjang array : ");
            array = new int[Convert.ToInt64(Console.ReadLine())];
            // mencari angka random
            toSearch = search.getRandomNumber(array.Length);
            // menentukkan nilai elemen elemen array
            search.setArray(array.Length, ref array);
            /* Memilih Metode Pencarian
             * 1. Sequential Search
             * 2. Binary Search 
             */
            Console.WriteLine("Metode Pencarian");
            Console.Write("Pilihan (1.Sequential/2.Binary): ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            // Begin timing.
            stopwatch.Start();
            if(pilih==1)
                search.SequentialSearch(toSearch, array);
            else if (pilih == 2)
                search.BinarySearch(toSearch, array);

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        private void SequentialSearch(int a,int[] b)
        {
            int idx;
            foreach(int element in b)
            {
                if (element == a)
                {
                    idx = Array.IndexOf(b, a);
                    String output = a.ToString();
                    Console.WriteLine(output + " ditemukan di index ke -" + idx);
                    return;
                }
            }
            Console.WriteLine(a + "tidak ditemukan");
        }

        private void BinarySearch(int a, int[] b)
        {
            int idx = Array.BinarySearch(b, a);
            if (idx < 0)
            {
                Console.WriteLine("({0}) tidak ditemukan", a);
            }
            else
            {
                a = Convert.ToInt32(a);
                Console.WriteLine(a + " ditemukan di indeks ke-{1}" + idx);
            }
        }
        private void setArray(int a, ref int[] b)
        {
            int counter = 0;
            for (int i = 0; i < a; i++)
            {
                b[i] = counter++;
            }
        }

        private int getRandomNumber(int b)
        {
            Random rand = new Random();
            return rand.Next(1, b + 1);
        }
    }
}
