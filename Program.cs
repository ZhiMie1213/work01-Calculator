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

			while( true)
			{
				if ( r == "" ) {
					string right = k.ToString();

					Console.WriteLine( "何算" );
					string aida = Console.ReadLine( );
					Console.WriteLine( "右" );
					Console.WriteLine( right );
					Console.WriteLine( "左" );
					string left = Console.ReadLine( );

					if ( aida == "t")
					{
						k = plus(right, left);
					}else if ( aida == "h")
					{
						k = minus(right, left);
					}else if ( aida == "k")
					{
						k = multiplication(right, left);
					}else if ( aida == "w")
					{
						k = division(right, left);
					}

					Console.WriteLine( );
					Console.WriteLine( "答えは" );
					Console.WriteLine( k );
					Console.WriteLine( );

				}else if ( r == "r")
				{
					k = 0;

					Console.WriteLine("何算");
					string aida = Console.ReadLine();
					Console.WriteLine("右");
					string right = Console.ReadLine();;
					Console.WriteLine("左");
					string left = Console.ReadLine();

					if (aida == "t")
					{
						k = plus(right, left);
					}
					else if (aida == "h")
					{
						k = minus(right, left);
					}
					else if (aida == "k")
					{
						k = multiplication(right, left);
					}
					else if (aida == "w")
					{
						k = division(right, left);
					}

					Console.WriteLine( );
					Console.WriteLine( "答えは" );
					Console.WriteLine( k );
					Console.WriteLine( );
				}

				Console.WriteLine( "リセット" );
				r = Console.ReadLine( );
				Console.WriteLine( );
			}
		}

		static double plus( string right, string left)
		{
			double m = double.Parse( right );
			double h = double.Parse( left );
			double answer = m + h;

			return answer;
		}

		static double minus( string right, string left)
		{
			double m = double.Parse(right);
			double h = double.Parse(left);
			double answer = m - h;

			return answer;
		}

		static double multiplication( string right, string left)
		{
			double m = double.Parse(right);
			double h = double.Parse(left);
			double answer = m * h;

			return answer;
		}

		static double division( string right, string left)
		{
			double m = double.Parse(right);
			double h = double.Parse(left);
			double answer = m / h;
			 
			return answer;
		}
	}
}