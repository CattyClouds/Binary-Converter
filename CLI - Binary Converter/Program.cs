using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI___Binary_Converter
{
	class Program
	{
		static void Main(string[] args)
		{
			string dash = String.Concat(Enumerable.Repeat("-", 64));

			do
			{
				Console.WriteLine(dash + "\nNumber Converter" + "\nConvert a whole number to binary and hexadecimal values.\n" + dash);
				Console.Write("Enter a number: ");

				string userInput = Console.ReadLine();
				int input = 0;

				if (int.TryParse(userInput, out input))
				{
					Console.Write("\nNumber      : " + input);
					Console.Write("\nBinary      : " + ConvertToBinary(input));
					Console.WriteLine("\nHexadecimal : " + ConvertToHex(input));

					Console.Write("\nAgain? (y/n): ");
					if (Console.ReadLine() == "y") Console.Clear();
					else break;
				}
				else
				{
					Console.WriteLine("Error: Invalid input. Please insert a number.\nPress any key to restart.");
					Console.ReadKey();
					Console.Clear();

				}
			} while (true);

			// End of program
			Console.WriteLine(dash + "\nPress any key to exit...");
			Console.ReadKey();
		}

		//-----------
		// Logic
		public static string ConvertToBinary(int input)
		{
			StringBuilder sb = new StringBuilder();
			while(input >= 1)
			{
				if (input % 2 == 1)
				{
					input = input / 2;
					sb.Append("1");
				}
				else if (input % 2 == 0)
				{
					input = input / 2;
					sb.Append("0");
				}
				else throw new Exception("Error converting to binary.");
			}
			string output = new string(sb.ToString().Reverse().ToArray());
			return output;
		}

		public static string ConvertToHex(int input)
		{
			StringBuilder sb = new StringBuilder();
			int remainder = 0;
			while (input > 0)
			{
				remainder = input % 16;
				input /= 16;
				sb.Insert(0, remainder.ToString("X"));
				//sb.AppendFormat();
			}
			return sb.ToString();
		}
	}
}
