using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC_Problem {
	public class Program {
		public static bool Can_spell (string word, List<string> data) {
			word = word.ToUpper ();
			char[] word_arr = word.ToCharArray ();

			for (int idx = 0; idx < word_arr.Length; idx++) {
				bool found = false;

				for (int i = 0; i < data.Count - 1; i++) {
					string[] block = data[i].Split (" ");

					if (word_arr[idx].ToString () == block[0] ||
						word_arr[idx].ToString () == block[1]) {
						data.RemoveAt (i);
						found = true;
						break;
					}
				}

				if (!found) { return false; }
			}
			return true;
		}
		static void first_try () {
			string[] data = new string[20] {
				"B O",
				"X K",
				"D Q",
				"C P",
				"N A",
				"G T",
				"R E",
				"T G",
				"Q D",
				"F S",
				"J W",
				"H U",
				"V I",
				"A N",
				"O B",
				"E R",
				"F S",
				"L Y",
				"P C",
				"Z M"
			};
			Dictionary<string, bool> tests = new Dictionary<string, bool> { { "test2", true },
				{ "test", false },
				{ "A", true },
				{ "BARK", true },
				{ "BOOK", false },
				{ "TREAT", true },
				{ "COMMON", false },
				{ "SQUAD", true },
				{ "CONFUSE", true }
			};
			foreach (KeyValuePair<string, bool> pair in tests) {
				if (Can_spell (pair.Key, data.ToList ()) != pair.Value) {
					Console.WriteLine ("expected {0} for '{1}' but got {2}", pair.Value, pair.Key, !pair.Value);
				}
			}
		}
		static void Main (string[] args) {
			first_try ();
		}
	}
}