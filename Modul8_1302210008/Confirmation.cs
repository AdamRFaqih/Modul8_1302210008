using System;
namespace Modul8_1302210008
{
	public class Confirmation
	{
		public string en { get; set; }
		public string id { get; set; }

		public Confirmation()
		{
		}
		public Confirmation(string en, string id)
		{
			this.en = en;
			this.id = id;
		}
	}
}

