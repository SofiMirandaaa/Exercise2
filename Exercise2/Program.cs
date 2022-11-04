using System;
   
namespace GPA_sort
{
    class Program
    {
        //Deklarasi array integer sama dengan 96
        private int[] a = new int[96];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int i;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yanag disimpan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya jumlah Nilai yang ingin di urutkan: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 96)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 96 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Masukkan Nilai ");
            Console.WriteLine("----------------------------");

            //User memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }


        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Urutan Nilai yang telah tersusun ");
            Console.WriteLine("----------------------");
            for (int SM = 0; SM < n; SM++)
            {
                Console.WriteLine(a[SM]);
            }
            Console.WriteLine("");
        }

        public void GPAsort()
        {
            for (int i = 1; i < n; i++) //For n - 1 passes
            {
                //Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int SM = 0; SM < n - i; SM++)
                {

                    if (a[SM] > a[n - 1]) //Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar elemen
                        int temp;
                        temp = a[SM];
                        a[SM] = a[n - 1];
                        a[n - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the Data Short class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();

            //Pemanggilan fungsi untuk mengurutkan elemen array
            myList.GPAsort();

            //Pemanggilan fungsi untuk menampilkan elemen array
            myList.display();

            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }

        





    }  

        
    

}