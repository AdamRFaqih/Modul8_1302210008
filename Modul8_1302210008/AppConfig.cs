using System;
using System.Text.Json;
namespace Modul8_1302210008
{

	public class AppConfig
	{
		public BankTransferConfig bankConfig;

		public AppConfig()
		{
		}

		public void readConfig()
		{
			string text = File.ReadAllText(@"./bank_transfer_config.json");
			bankConfig = JsonSerializer.Deserialize<BankTransferConfig>(text);
		}

		public void setDefault()
		{
			List<string> method = new List<string> { "RTO (Real Time)", "SKN", "RTGS", "BI FAST"};
			bankConfig = new BankTransferConfig("en", 25000000, 6500, 15000, method, "yes", "ya");
		}

		public void writeConfig()
		{
			var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(bankConfig, options);
			File.WriteAllText(@"./bank_transfer_config.json", jsonString);
		}

		public void changeLang()
		{
			if(bankConfig.lang == "en")
			{
				bankConfig.lang = "id";
				writeConfig();
				return;
			}
			bankConfig.lang = "en";
			writeConfig();
			return;
		}
	}
}

