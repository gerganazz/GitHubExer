using System;

class MainClass
{
	public static void Main ()
	{
		var hoursNeeded = int.Parse (Console.ReadLine ());
		var daysAvailable = int.Parse (Console.ReadLine ());
		var emplDoingOvertime = int.Parse (Console.ReadLine ());

		var daysForWork = daysAvailable * 0.9;
		var hoursForWork = daysForWork * 8.0;
		hoursForWork += emplDoingOvertime * daysAvailable * 2.0;	//employees doing overtime x 2 hours per day x all available days
		hoursForWork = Math.Floor(hoursForWork);
		var diff = hoursForWork - hoursNeeded;
			
		if (diff >= 0) {
			Console.WriteLine ("Yes!{0} hours left.", diff);
		} 
		else {
			Console.WriteLine ("Not enough time!{0} hours needed.", Math.Abs(diff));
		}

	}
}

