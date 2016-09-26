using System;
namespace _03.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			string mesec = Console.ReadLine().ToLower();
			double noshtyvki = double.Parse(Console.ReadLine());
			double cenaStudio = 0;
			double cenaApartament = 0;
			double newCenaStudio = 0;
			double newCenaApartament = 0;
			if (mesec == "may" || mesec == "october")
			{
				if (noshtyvki < 7 )
				{
					cenaApartament = (noshtyvki * 65);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", cenaApartament));
					cenaStudio = (noshtyvki * 50);
					newCenaStudio = cenaStudio - (cenaStudio * 5 / 100);
					Console.WriteLine("Studio: {0} lv." , string.Format("{0:0.00}", newCenaStudio));
				}
				else if (noshtyvki > 14.00 )
				{
					cenaApartament = (noshtyvki * 65);
					newCenaApartament = cenaApartament - (cenaApartament * 10 / 100);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", newCenaApartament));
					cenaStudio = (noshtyvki * 50);
					newCenaStudio = cenaStudio - (cenaStudio * 30 / 100);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", newCenaStudio));
				}
				else
				{
					cenaApartament = (noshtyvki * 65);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", cenaApartament));
					cenaStudio = (noshtyvki * 50);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", cenaStudio));
				}
			}
			else if (mesec == "june" || mesec == "september")
			{
				if (noshtyvki <= 14)
				{
					cenaApartament = (noshtyvki * 68.70);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", cenaApartament));
					cenaStudio = (noshtyvki * 75.20);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", cenaStudio));

				}
				if (noshtyvki > 14)
				{
					cenaApartament = (noshtyvki * 68.70);
					newCenaApartament = cenaApartament - (cenaApartament * 10 / 100);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", newCenaApartament));
					cenaStudio = (noshtyvki * 75.20);
					newCenaStudio = cenaStudio - (cenaStudio * 20 / 100);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", newCenaStudio));

				}
			}
			else if (mesec == "july" || mesec == "august")
			{
				if (noshtyvki <= 14)
				{
					cenaApartament = (noshtyvki * 77);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", cenaApartament));
					cenaStudio = (noshtyvki * 76);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", cenaStudio));
				}
				else if (noshtyvki > 14)
				{
					cenaApartament = (noshtyvki * 77);
					newCenaApartament = cenaApartament - (cenaApartament * 10 / 100);
					Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", newCenaApartament));
					cenaStudio = (noshtyvki * 76);
					Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", cenaStudio));
				}
			}
		}
	}
}