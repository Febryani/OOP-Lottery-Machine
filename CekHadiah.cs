using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    class CekHadiah : Dasar
    {

		public void CountMatch(char[] arr, string reff)
        {
			for (int i = 0; i < arr.Length; i++)
			{
				if (reff.Contains(arr[i].ToString()))
				{
					matchCounter++;
				}
				continue;
			}
		}

		public String StoreName
		{ get; set; }

		public void WinOrNo()
        {
			Console.WriteLine($"Banyak angka yang match adalah sejumlah {matchCounter} angka");
			System.Threading.Thread.Sleep(3000);

			if (matchCounter >= 3)
			{
				Console.WriteLine("");
				Console.WriteLine("Selamat Anda Beruntung! Anda berhak mendapatkan hadiah berupa : ");
				Console.WriteLine("");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("1. 2 tiket naik haji");
				Console.WriteLine("2. Uang senilai Rp. 50.000.000,-");
				Console.WriteLine("3. Emas seberat 10 gram");
				Console.WriteLine("4. Voucher belanja Betamart diskon 25%");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("");
				Console.WriteLine("Silahkan hubungi petugas Betamart untuk melakukan pengambilan hadiah!");
				System.Threading.Thread.Sleep(2000);
			}
			else if (matchCounter >= 1 && matchCounter < 3)
			{
				Console.WriteLine("");
				Console.WriteLine("Selamat Anda Beruntung! Anda berhak mendapatkan hadiah berupa: ");
				Console.WriteLine("");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("Voucher belanja Betamart diskon 25%");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("");
				Console.WriteLine("Silahkan hubungi petugas Betamart untuk pengambilan hadiah!");
				System.Threading.Thread.Sleep(2000);
			}
			else
			{
				System.Threading.Thread.Sleep(3000);
				Console.WriteLine("");
				Console.WriteLine("Yah... Sayangnya Anda belum beruntung. Coba lagi lain kali.");
				System.Threading.Thread.Sleep(2000);
			}
		}

		public override void Greeting()
        {
            Header();
            Console.WriteLine($"Terima kasih atas kunjungannya {StoreName}!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
