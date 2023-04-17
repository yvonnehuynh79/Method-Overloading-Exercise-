using System;
namespace MethodOverloading
{
	public class Methods
	{
		
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static double Add(double a, double b)
		{
			return a + b;
		}
		public static decimal Add(decimal a, decimal b)
		{
			return a + b;
		}
		public static string Add( int a, int b, bool withDollars)
		{
			if (withDollars && ( a+ b) != 1)
			{
				return $"{a + b} dollars";
			}
			else if (withDollars && (a + b) == 1)
			{
				return $"{a + b} dollar";
			}
			else
			{
				return $"{a + b}";
			}
				

		}

	}
		
}

