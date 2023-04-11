using System;
namespace Modul8_1302210008
{
	public class Transfer
	{
		public int treshold { get; set; }
		public int low_fee { get; set; }
		public int high_fee { get; set; }


		public Transfer()
		{
		}
		public Transfer(int treshold, int low_fee, int high_fee)
		{
			this.treshold = treshold;
			this.low_fee = low_fee;
			this.high_fee = high_fee;
		}
	}
}

