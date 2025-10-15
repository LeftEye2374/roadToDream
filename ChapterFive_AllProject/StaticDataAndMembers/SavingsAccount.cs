using System;

namespace StaticDataAndMembers;

public class SavaingsAccount
{
	public static double currInterestRate = 0.04;
	public double currBalance;

	public SavaingsAccount(double balance)
	{
		currBalance = balance;
	}

	public static void SetInterestRate(double newRate) => currInterestRate = newRate;

	public static double GetInterestRate() => currInterestRate;
	

}