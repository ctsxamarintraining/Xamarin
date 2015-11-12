package com.xamarin;

public class Pi
{
	public static double calculate(int iterations)
	{
		double quarterPi = 0;

		for (int i = 0; i < iterations; i++)
		{
			double term = 1.0 / (2 * i + 1);

			int sign = i % 2 == 0 ? 1 : -1;

			quarterPi += sign * term;
		}

		return quarterPi * 4;
	}
}