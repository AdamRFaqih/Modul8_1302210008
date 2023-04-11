using System;
namespace Modul8_1302210008
{
	public class BankTransferConfig
	{
		public string lang { get; set; }
		public Transfer transfer { get; set; }
		public List<string> method { get; set; }
		public Confirmation confirmation { get; set; }

		public BankTransferConfig()
		{
		}
		public BankTransferConfig(string lang, int treshold, int low_fee, int high_fee, List<string> method, string en, string id)
		{
			this.lang = lang;
			transfer = new Transfer(treshold, low_fee, high_fee);
			this.method = method;
			confirmation = new Confirmation(en, id);
		}
	}
}

