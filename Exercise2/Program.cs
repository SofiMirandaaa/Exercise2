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
        }


    }  
        
    

}