using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace test_abc {
	public class UnitTest1 {
		[Fact]
		public void Test1 () {

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
			Dictionary<string, bool> tests = new Dictionary<string, bool> { { "A", true },
				{ "BARK", true },
				{ "BOOK", false },
				{ "TREAT", true },
				{ "COMMON", false },
				{ "SQUAD", true },
				{ "CONFUSE", true }
			};
			foreach (KeyValuePair<string, bool> pair in tests) {
				Assert.Equal(pair.Value,abc.Program.Can_spell (pair.Key, data.ToList ()) );
				//Console.WriteLine ("expected {0} for '{1}' but got {2}", pair.Value, pair.Key, !pair.Value);
			}
		}
	}
}