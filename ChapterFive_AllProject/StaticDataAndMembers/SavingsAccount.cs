using System;

namespace StaticDataAndMembers;

class SavaingAccount
{
	public static double currInterestRate = 0.04;
	public double currBalance;

	public SavaingAccount(double balance)
	{
		currBalance = balance;
	}

}