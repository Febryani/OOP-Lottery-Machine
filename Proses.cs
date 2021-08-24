using System;

namespace ConsoleAppOOP
{
	class Proses : Dasar
	{
		CekHadiah program = new CekHadiah();

		static void Main(string[] args)
		{
			Proses start = new Proses();
			start.Transaksi();
		}


		public override void Greeting()
		{
			Header();
			Console.WriteLine(" ");
			Console.WriteLine("               ~   SELAMAT DATANG DI TOKO KAMI!  ~ ");
			Console.WriteLine(" ");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("Halo... Siapa namamu?");
			//setName();
			program.StoreName = Console.ReadLine();
			Console.Clear();
			Header();
			Console.WriteLine($"Halo {program.StoreName}!");
		}

		private void Menu()
		{
			Console.WriteLine(" ");
			Console.WriteLine("Silahkan pilih menu dibawah ini:");
			Console.WriteLine("1. Beli Lotre");
			Console.WriteLine("2. Undi Lotre");
		}

		private void BeliUndi()
		{
			var random = new Random();

			Console.Clear();
			Header();
			Console.WriteLine($"Harga tiket lotre: Rp {hargaLotre}");

			offer:
			Console.WriteLine("Mau beli? (Jawab dengan 'ya' atau 'tidak')");
			string jawab = Console.ReadLine();
			if (jawab == "ya")
			{
				Console.Clear();
				Header();

				quanBeli:
				Console.WriteLine("Berapa banyak? Maksimal pembelian 3 tiket undian");
				quantity = int.Parse(Console.ReadLine());

				if (quantity <= 3)
				{
					Console.Clear();
					Header();
					Console.WriteLine("Tiket lotre akan dicetak");
					Console.WriteLine($"Silahkan selesaikan pembayaran belanjaan anda di kasir {program.StoreName}");
					System.Threading.Thread.Sleep(1000);
					Console.WriteLine($"Total belanja: Rp. {Total(quantity, hargaLotre)}");
					Console.WriteLine(" ");
					System.Threading.Thread.Sleep(1000);
					Console.WriteLine("Berikut kode lotre anda:");

					//store lotre code as array value
					for (int i = 0; i < quantity; i++)
					{
						lotreCodes[i] = Convert.ToString(random.Next(10000, 99999));
						System.Threading.Thread.Sleep(1000);
						Console.WriteLine($"{(i + 1)}. {lotreCodes[i]}");
					}

					Console.WriteLine(" ");
					System.Threading.Thread.Sleep(1000);
					konfirmasi:
					Console.WriteLine("Mau undi tiket anda sekarang?");
					Console.WriteLine("1. ya");
					Console.WriteLine("2. tidak");
					int opsi = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Header();

					if (opsi == 1)
					{
						for (int i = 0; i < quantity; i++)
						{
							Console.WriteLine((i + 1) + ". " + lotreCodes[i]);
						}
						Console.WriteLine("");
						Console.WriteLine("Tiket urutan nomor berapa yang ingin di undi?");
						opsi = Convert.ToInt32(Console.ReadLine());
						codeUndi = lotreCodes[opsi - 1].ToCharArray(0, 5);
						codeReference = Convert.ToString(random.Next(10000, 99999));
						Console.Clear();
						Header();
						Console.WriteLine($"Angka pada tiket lotre : {lotreCodes[opsi - 1]}");
						System.Threading.Thread.Sleep(2000);
						Console.WriteLine("");
						Console.WriteLine($"Angka beruntung        : {codeReference}");
						Console.WriteLine("");
						System.Threading.Thread.Sleep(2000);

                        program.CountMatch(codeUndi, codeReference);
						program.WinOrNo();
					}
					else if (opsi != 1 && opsi != 2)
                    {
						Console.Clear();
						Header();
						Console.WriteLine("Ada kesalahan input. Silahkan ulangi kembali");
						Console.Clear();
						Header();
						goto konfirmasi;
					}
				}
				else
				{
					Console.Clear();
					Header();
					Console.WriteLine("Pembelian melebihi batas.");
					goto quanBeli;
				}

			}
			else if (jawab == "tidak")
			{

				Console.Clear();
				Header();
				Console.WriteLine("Baik terima kasih");
			}
			else
			{
				Console.Clear();
				Header();
				Console.WriteLine("Ada kesalahan input. Periksa kembali!");
				goto offer;
			}
		}
			

		private void Undi()
		{
			Console.Clear();
			var random = new Random();

			error_reinput:
			Header();
			Console.WriteLine("Silahkan masukan 5 single number pada baris berbeda ");
			Console.WriteLine("sesuai nomor yang tertera pada tiket lotre Anda : ");
			for (int i = 0; i < input.Length; i++)
			{
				try
				{
					input[i] = char.Parse(Console.ReadLine());
					numberInt = int.Parse(input);
				}
				catch
				{
					Console.WriteLine("Ada kesalahan input. Pastikan yang anda masukan adalah single number!");
					System.Threading.Thread.Sleep(2000);
					Console.Clear();
					goto error_reinput;
				}

			}

			if (input.Length == 5)
			{
				string newInput = string.Join("", input);

				if (int.TryParse(newInput, out numberInt))
				{
					Console.WriteLine("");
					Console.WriteLine($"Angka pada tiket lotre Anda : {newInput}");
					Console.WriteLine("");
					System.Threading.Thread.Sleep(2000);
					Console.WriteLine($"Angka beruntung             : {codeReference = Convert.ToString(random.Next(10000, 99999))}");
					Console.WriteLine("");
					newInputs = newInput.ToCharArray(0, 5);
					System.Threading.Thread.Sleep(3000);

					program.CountMatch(newInputs, codeReference);
					program.WinOrNo();
				}
			}
		}

		private int Total(int x, int y)
		{
			return x * y;
		}

		private void ToFinal()
		{
			System.Threading.Thread.Sleep(3000);
			Console.Clear();
			Header();
			Console.WriteLine(" ");
			Console.WriteLine("Selanjutnya ...");
			Console.WriteLine("1. Kembali ke menu awal");
			Console.WriteLine("2. Keluar");
		}

		private void Transaksi()
        {
			int pilih;
			string finalOpsi;

			welcome:
			Greeting();
			backToMenu:
			Menu();
			pilih = int.Parse(Console.ReadLine());

			switch (pilih)
			{
				case 1:
					BeliUndi();
					ToFinal();
					finalOpsi = Console.ReadLine();

					if (finalOpsi == "1")
					{
						Console.Clear();
						Header();
						goto backToMenu;
					}
					else
					{
						Console.Clear();
						goto finish;
					}
					break;

				case 2:
					Undi();
					ToFinal();
					finalOpsi = Console.ReadLine();

					if (finalOpsi == "1")
					{
						Console.Clear();
						Console.WriteLine("Ketik pilihan Anda");
						Header();
						goto backToMenu;
					}
					else
					{
						Console.Clear();
						goto finish;
					}
					break;

				default:
					Console.Clear();
					Header();
					Console.WriteLine("Sepertinya ada kesalahan pengetikan. ");
					Console.WriteLine("Periksa kembali ya. Silahkan ketikan pilihan!");
					goto backToMenu;
					break;
			}

			finish:
			program.Greeting();
			goto welcome;
		}
	}
}
