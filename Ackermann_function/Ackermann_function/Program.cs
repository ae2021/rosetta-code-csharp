using System;

namespace Ackermann_function {
	class Program {
		static UInt64 Ackermann (UInt64 m, UInt64 n) {
			if (m == 0) {
				return n + 1;
			} else if (n == 0) {
				return Ackermann (m - 1, 1);
			} else {
				return Ackermann (m - 1, Ackermann (m, n - 1));
			}
		}
		static int Ackermann2 (int m, int n) {
			if (m == 0) {
				return n + 1;
			} else if (m == 1) {
				return n + 2;
			} else if (m == 2) {
				return 2 * n + 3;
			} else if (m == 3) {
				return 8 << n - 3;
			} else if (n == 0) {
				return Ackermann2 (m - 1, 1);
			}
			return Ackermann2 (m - 1, Ackermann2 (m, n - 1));
		}
		static void Main (string[] args) {
			Console.WriteLine (Ackermann (1, 2));
			Console.WriteLine (Ackermann2 (1, 2));
		}
	}
}