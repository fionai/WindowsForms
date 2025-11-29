using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public byte Weekdays { get; set; }
		public string Filename { get; set; }
		public void WeekdaysFromArray(int[] days)
		{
			if (days.Length > 7) return;
			for (int i = 0; i < days.Length; i++)
			{
				Weekdays |= (byte)(1 << days[i]);
			}
		}
		public override string ToString()
		{
			return $"{Date.ToString("yyyy.MM.dd")}--{Time.ToString("hh:mm:ss tt")} [{Weekdays}] {Filename.Split('\\').Last()}";

		}
	}
}
