using System;

class MainClass
{
	public static void Main ()
	{
		var n = int.Parse (Console.ReadLine ());
		var left = n * 3;
		var mid = 0;
		var right = n * 2 - mid - 2;

		//Draw the top part
		for (int row = 0; row < n; row++) {
			Console.WriteLine ("{0}*{1}*{2}", new string(' ', left), new String(' ', mid), new string(' ', right));
			mid++;
			right--;
		}
			
		//Draw the handle
		mid--;
		right++;
		for (int row = 0; row < n / 2; row++) {
			Console.WriteLine ("{0}*{1}*{2}", new string('*', left), new String(' ', mid), new string(' ', right));
		}

		//Draw the bottom part
		for (int row = 0; row < n / 2 - 1; row++) {
			Console.WriteLine ("{0}*{1}*{2}", new string(' ', left), new String(' ', mid), new string(' ', right));
			left--;
			mid += 2;
			right--;
		}

		//Draw the last row
		Console.WriteLine ("{0}{1}{2}", new string(' ', left), new String('*', mid + 2), new string(' ', right));
	}
}

