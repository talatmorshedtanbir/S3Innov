using System;
using static System.Console;

public class Program
{
	public static void Main()
	{
		string startDate, endDate;
		Console.WriteLine("Start time");
		startDate = Console.ReadLine();
		Console.WriteLine("End time");
		endDate = Console.ReadLine();
		DateTime start =
		DateTime.Parse(startDate, System.Globalization.CultureInfo.InvariantCulture);

		DateTime end =
		DateTime.Parse(endDate, System.Globalization.CultureInfo.InvariantCulture);


		TimeSpan pickstart = new TimeSpan(9, 0, 0);
		TimeSpan pickend = new TimeSpan(22, 59, 59);

		TimeSpan offpickstart1 = new TimeSpan(12, 0, 0);
		TimeSpan offpickend1 = new TimeSpan(8, 59, 59);

		TimeSpan offpickstart2 = new TimeSpan(23, 0, 0);
		TimeSpan offpickend2 = new TimeSpan(23, 59, 59);

		double taka = 0.0;
		while (start <= end)
		{
			start = start.AddSeconds(21);
			if (start.TimeOfDay >= pickstart && start.TimeOfDay <= pickend)
			{
				taka += 30;
			}
			else
			{
				taka += 20;
			}

		}

		WriteLine($"{taka / 100.0} taka");
	}
}