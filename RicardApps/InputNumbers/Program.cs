using System;
using System.Collections.Generic;
using System.Linq;

namespace InputNumbers {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Help! The Princess has been captured and we need 5 numbers to save her...");
			Console.WriteLine("\n<Insert aschii animation of Bowser flying away>\n\n");

			var grammar = new[] {
				"First",
				"Second",
				"Third",
				"Fourth",
				"Fifth"
			};
			var inputNumbers = new List<int>();
			var isRetry = false;
			while (true) {
				var numbersCount = inputNumbers.Count;
				
				// Done?
				if (numbersCount > 4) {
					break;
				}

				// User input
				if (!isRetry) {
					Console.Write($"{grammar[numbersCount]} number please: ");
				}				
				var input = Console.ReadLine();
				
				// Convert to int
				int? num = null;
				try {
					num = int.Parse(input);
				} catch { }

				// Valid?
				if (num is null) {
					Console.WriteLine($"{input} doesn't seem like a valid number. Please try again.");
					isRetry = true;
				} else if (inputNumbers.Contains((int)num)) {
					Console.WriteLine($"You already listed {num}. Please try again");
					isRetry = true;
				} else {
					inputNumbers.Add((int)num);
					isRetry = false;
				}
			}

			// Summary
			Console.WriteLine("\n\nThank you brave warrior. Here are the numbers you listed:\n");
			Console.WriteLine(string.Join("\n", inputNumbers.OrderBy(x => x)));

			Console.WriteLine("\n\n<Some other Mario gag...>\n");

			Exit();
		}

		static void Exit() {
			Console.WriteLine("\nPress any key to close the window...");
			var dontcare = Console.ReadKey();
		}
	}
}
