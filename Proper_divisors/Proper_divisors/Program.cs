using System;
using System.Collections.Generic;

namespace Proper_divisors {
	class Program {

		//Create a routine to generate all the proper divisors of a number
		static int[] Proper_divisors (int x) {
			List<int> result = new List<int> ();
			for (int i = 1; i < x; i++) {
				if (x % i == 0) { result.Add (i); }
			}
			return result.ToArray ();
		}

		//use Proper_divisors() to show the proper divisors of the numbers 1 to 10 inclusive.
		static void ten () {
			for (int i = 1; i < 11; i++) {
				int[] tmp = Proper_divisors (i);
				Console.WriteLine ("num: {0} - count: {1} - raw: {2}", i,tmp.Length,
					string.Join (", ", tmp));
			}
		}
		//Find a number in the range 1 to 20,000 with the most proper divisors. Show the number and just the count of how many proper divisors it has.
		static void most_proper_divisors (int x) {
			int most = 0;
			int num = 0;
			for (int i = 1; i < x; i++) {
				int[] tmp = Proper_divisors (i);
				if (tmp.Length > most) {
					most = tmp.Length;
					num = i;
				}
			}
			Console.WriteLine ("num: {0} - count: {1} - raw: {2}", num, most, string.Join (", ", Proper_divisors (num)));
		}
		static void Main (string[] args) {
			/* Examples
			The proper divisors of     6     are   1, 2, and 3.
			The proper divisors of   100   are   1, 2, 4, 5, 10, 20, 25, and 50.  */
			Console.WriteLine (string.Join (", ", Proper_divisors (6)));
			Console.WriteLine (string.Join (", ", Proper_divisors (100)));
			ten ();
			most_proper_divisors (20000);
		}
	}
}