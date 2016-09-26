using System;

class MainClass
{
	public static void Main ()
	{
		string month = Console.ReadLine ().ToLower();
		var days = int.Parse (Console.ReadLine ());

		var studioDayPrice = 0.0;
		var apartDayPrice = 0.0;
		var studioTotalPrice = 0.0;
		var apartTotalPrice = 0.0;
		var studioDiscount = 0.0;
		var apartDiscount = (days > 14) ? 0.1 : 0.0;

		switch (month) {
		case "may":
		case "october":
			studioDayPrice = 50.0;
			apartDayPrice = 65.0;
			if (days > 14)
				studioDiscount = 0.3;
			else if (days > 7)
				studioDiscount = 0.05;
			break;
				
		case "june":
		case "september":
			studioDayPrice = 75.2;
			apartDayPrice = 68.7;
			if (days > 14)
				studioDiscount = 0.2;	
			break;
			
		case "july":
		case "august":
			studioDayPrice = 76;
			apartDayPrice = 77;
			break;

		default:
			break;
		}

		studioTotalPrice = days * studioDayPrice;
		apartTotalPrice = days * apartDayPrice;

		if (studioDiscount > 0) {
			studioTotalPrice -= studioTotalPrice * studioDiscount;
		}

		if (apartDiscount > 0) {
			apartTotalPrice -= apartTotalPrice * apartDiscount;
		}

		Console.WriteLine ("Apartment: {0:f2} lv.", apartTotalPrice);
		Console.WriteLine ("Studio: {0:f2} lv.", studioTotalPrice);

		Console.WriteLine ("3.1456 with 0:f2 -> {0:f2}", 3.1456);
		Console.WriteLine ("3.1456 with 0:0.00 -> {0:0.00}", 3.1456);
		Console.WriteLine ("3.1456 with Math.Round(num, 2) -> {0}", Math.Round(3.1456, 2));

		//		3.1456 with 0:f2 -> 3.15
		//		3.1456 with 0:0.00 -> 3.15
		//		3.1456 with Math.Round(num, 2) -> 3.15
	}
}

