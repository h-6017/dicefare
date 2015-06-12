using System;
using System.Collections.Generic;
using System.Linq;

namespace dCC_lab_10_3
{
	internal class Program
	{
		private static string odd_word;

		private static int middle;

		private static string first_part;

		private static string second_part;

		static Program()
		{
			Program.middle = 0;
		}

		public Program()
		{
		}

		private static void Main(string[] args)
		{
			int i;
			Console.WriteLine("Number of command line parameters = {0}", (int)args.Length);
			if (args.Count<string>() % 2 != 0)
			{
				string odd_word = args[(int)args.Length / 2];
				Program.middle = odd_word.Length / 2;
				Program.first_part = odd_word.Substring(0, Program.middle);
				Program.second_part = odd_word.Substring(Program.middle);
			}
			int total_args = (int)args.Length;
			int second_half = total_args - total_args / 2;
			List<string> arguments_first_half = new List<string>();
			List<string> arguments_second_half = new List<string>();
			for (i = 0; i < total_args / 2; i++)
			{
				arguments_first_half.Add(args[i]);
			}
			arguments_first_half.Add(Program.first_part);
			arguments_second_half.Add(Program.second_part);
			for (i = second_half; i < total_args; i++)
			{
				arguments_second_half.Add(args[i]);
			}
			for (i = 0; i < arguments_first_half.Count; i++)
			{
				Console.Write(string.Concat(arguments_first_half[i], " "));
			}
			Console.WriteLine();
			for (i = 0; i < arguments_second_half.Count; i++)
			{
				Console.Write(string.Concat(arguments_second_half[i], " "));
			}
			Console.ReadKey();
		}
	}
}