using System;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());

		var num = n;
		var digit3 = num % 10;
		num /= 10;
		var digit2 = num % 10;
		num /= 10;
		var digit1 = num % 10;

		num = n;
		var rows = digit1 + digit2;
		var cols = digit1 + digit3;

		for (int r = 0; r < rows; r++) 
		{
			for (int c = 0; c < cols; c++) 
			{
				if (num % 5 == 0) 
				{
					num -= digit1;
				} 
				else if (num % 3 == 0) 
				{
					num -= digit2;
				} 
				else
					num += digit3;
				
				Console.Write (num + " ");
			}

			Console.WriteLine ();
		}
	}
}

