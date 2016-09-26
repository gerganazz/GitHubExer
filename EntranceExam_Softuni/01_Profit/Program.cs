using System;

class MainClass
{
	public static void Main ()
	{
		int workDays = int.Parse (Console.ReadLine ());
		var dayWageUsd = double.Parse (Console.ReadLine ());
		var exchUsdBgn = double.Parse (Console.ReadLine ());

		var monthWageUsd = workDays * dayWageUsd;
		var yearWageUsd = 12 * monthWageUsd + 2.5 * monthWageUsd;	// plus bonus of 2.5 month wage
		yearWageUsd = yearWageUsd * 0.75;	// les taxes of 25%
		var yearWageBgn = yearWageUsd * exchUsdBgn;
		var dailyProfit = yearWageBgn / 365;

		Console.WriteLine ("{0:f2}", dailyProfit);
	}
}

