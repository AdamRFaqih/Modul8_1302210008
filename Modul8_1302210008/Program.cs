using System;
namespace Modul8_1302210008
{
    public class Program
    {
        public static void Main()
        {
            AppConfig appConfig = new AppConfig();
            int jumlaTF, biayaTF;
            string metode, confirm;
            try
            {
                appConfig.readConfig();
            }
            catch
            {
                appConfig.setDefault();
                appConfig.writeConfig();
                appConfig.readConfig();
            }
            //appConfig.changeLang();
            if(appConfig.bankConfig.lang == "en")
            {
                Console.Write("Please insert the amount of money to transfer: ");
                jumlaTF = Convert.ToInt32(Console.ReadLine());
                if(jumlaTF <= appConfig.bankConfig.transfer.treshold)
                {
                    biayaTF = appConfig.bankConfig.transfer.low_fee;
                }
                else
                {
                    biayaTF = appConfig.bankConfig.transfer.high_fee;
                }
                Console.WriteLine($"Transfer Fee = {biayaTF}");
                Console.WriteLine($"Total Amount = {jumlaTF + biayaTF}");
                Console.WriteLine("Select transfer method");
                for (int i = 0; i < appConfig.bankConfig.method.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {appConfig.bankConfig.method[i]}");
                }
                Console.Write("Your choice: ");
                metode = Console.ReadLine();
                Console.Write($"Please type {appConfig.bankConfig.confirmation.en} to confirm the transaction: ");
                confirm = Console.ReadLine();
                if (!appConfig.bankConfig.method.Contains(metode) && confirm != appConfig.bankConfig.confirmation.en)
                {
                    Console.WriteLine("Transfer is cancelled");
                    return;
                }
                Console.WriteLine("Transfer is completed");
                return;

            }
            Console.Write("Masukan jumlah uang yang akan di transfer: ");
            jumlaTF = Convert.ToInt32(Console.ReadLine());
            if (jumlaTF <= appConfig.bankConfig.transfer.treshold)
            {
                biayaTF = appConfig.bankConfig.transfer.low_fee;
            }
            else
            {
                biayaTF = appConfig.bankConfig.transfer.high_fee;
            }
            Console.WriteLine($"Biaya Transfer = {biayaTF}");
            Console.WriteLine($"Total Biaya = {jumlaTF + biayaTF}");
            Console.WriteLine("Pilih Metode Transfer");
            for (int i = 0; i < appConfig.bankConfig.method.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {appConfig.bankConfig.method[i]}");
            }
            Console.Write("Pilihan Anda: ");
            metode = Console.ReadLine();
            Console.Write($"ketik {appConfig.bankConfig.confirmation.id} untuk mengkonfirmasi transaksi: ");
            confirm = Console.ReadLine();
            if (!appConfig.bankConfig.method.Contains(metode) || confirm != appConfig.bankConfig.confirmation.id)
            {
                Console.WriteLine("Transfer dibatalkan");
                return;
            }
            Console.WriteLine("Proses tranfer berhasil");
            return;
        }
    }
}