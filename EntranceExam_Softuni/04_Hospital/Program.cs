using System;

class MainClass
{
	public static void Main ()
	{
		var days = int.Parse (Console.ReadLine ());
		var availableDoctors = 7;
		var treatedPatients = 0;
		var untreatedPatients = 0;

		for (int day = 1; day <= days; day++) {

			if (day % 3 == 0 && untreatedPatients > treatedPatients) {				
					availableDoctors++;
			}

			var incomingPatients = int.Parse (Console.ReadLine ());
			var treatedPatientsThisDay = Math.Min(availableDoctors, incomingPatients);
			treatedPatients += treatedPatientsThisDay;
			untreatedPatients += incomingPatients - treatedPatientsThisDay;

		}
			
		Console.WriteLine ("Alabala: {0}.", treatedPatients);
		Console.WriteLine ("Mubababa: {0}.", untreatedPatients);

	}
}

