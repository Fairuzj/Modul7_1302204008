using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302204008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig bankTransferConfig = new BankTransferConfig();
            dynamic bankConfig = bankTransferConfig.ReadJson();

            if (bankConfig.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else if (bankConfig.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            }

            int jumlah = int.Parse(Console.ReadLine());
            int fee;
            if (jumlah<= (int)bankConfig.transfer.threshold)
            {
                fee = bankConfig.transfer.low_fee;
            }
            else
            {
                fee = bankConfig.transfer.high_fee;
            }

            if (bankConfig.lang == "en")
            {
                Console.WriteLine("Transfer fee = " + fee);
                Console.WriteLine("Total amount = " + (fee + jumlah) + "\n");
                Console.WriteLine("Select Transfer Method");
            }
            else if (bankConfig.lang == "id")
            {
                Console.WriteLine("Biaya Transfer = "   + fee);
                Console.WriteLine("Total Biaya = "      + (fee + jumlah) + "\n");
                Console.WriteLine("Pilih Metode Transfer");
            }
            int index = 0;
            foreach (var method in bankConfig.methods)
            {
                index++;
                Console.WriteLine(index + ". " + method);
            }
            Console.WriteLine();
            Console.ReadLine();

            string konfirmasi;
            if (bankConfig.lang == "en")
            {
                Console.WriteLine("Please type '" + bankConfig.confirmation.en + "' to confirm the transaction:");
                konfirmasi = Console.ReadLine();
                if (konfirmasi == (string)bankConfig.confirmation.en)
                {
                    Console.WriteLine("The Transfer Is Completed");
                }
                else
                {
                    Console.WriteLine("Transfer Is Cancelled");
                }
            }
            else if (bankConfig.lang == "id")
            {
                Console.WriteLine("Ketik '" + bankConfig.confirmation.id + "' untuk mengkonfirmasi transaksi anda:");
                konfirmasi = Console.ReadLine();
                if (konfirmasi == (string)bankConfig.confirmation.id)
                {
                    Console.WriteLine("Proses Transfer BERHASIL");
                }
                else
                {
                    Console.WriteLine("Transfer DIBATALKAN");
                }
            }
        }
    }
}
