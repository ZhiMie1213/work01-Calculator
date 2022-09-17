using System;
using System.Reflection.Metadata;
using System.Transactions;

namespace Calculator
{
	class Calculator
	{
		static void Main(string[] args)
		{
			double k = 0;
			string r = "r";

			while (true)
			{
				if (r == "")
				{
					string left = k.ToString();

					Console.WriteLine("何算");
					string aida = Console.ReadLine();
					Console.WriteLine("左");
					Console.WriteLine(left);
					Console.WriteLine("右");
					string right = Console.ReadLine();

					if (aida == "t")
					{
						k = plus(left, right);
					}
					else if (aida == "h")
					{
						k = minus(left, right);
					}
					else if (aida == "k")
					{
						k = multiplication(left, right);
					}
					else if (aida == "w")
					{
						k = division(left, right);
					}

					Console.WriteLine();
					Console.WriteLine("答えは");
					Console.WriteLine(k);
					Console.WriteLine();

				}
				else if (r == "r")
				{
					k = 0;

					Console.WriteLine("何算");
					string aida = Console.ReadLine();
					Console.WriteLine("左");
					string left = Console.ReadLine();
					Console.WriteLine("右");
					string right = Console.ReadLine();

					if (aida == "t")
					{
						k = plus(left, right);
					}
					else if (aida == "h")
					{
						k = minus(left, right);
					}
					else if (aida == "k")
					{
						k = multiplication(left, right);
					}
					else if (aida == "w")
					{
						k = division(left, right);
					}

					Console.WriteLine();
					Console.WriteLine("答えは");
					Console.WriteLine(k);
					Console.WriteLine();
				}

				Console.WriteLine("リセット");
				r = Console.ReadLine();
				Console.WriteLine();
			}
		}

		static double plus(string left, string right)
		{
			double h = double.Parse(left);
			double m = double.Parse(right);
			double answer = h + m;

			return answer;
		}

		static double minus(string left, string right)
		{
			double h = double.Parse(left);
			double m = double.Parse(right);
			double answer = h - m;

			return answer;
		}

		static double multiplication(string left, string right)
		{
			double h = double.Parse(right);
			double m = double.Parse(left);
			double answer = h * m;

			return answer;
		}

		static double division(string left, string right)
		{
			double h = double.Parse(left);
			double m = double.Parse(right);
			double answer = h / m;

			return answer;
		}
	}
}