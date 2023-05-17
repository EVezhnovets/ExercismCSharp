static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
    {
        < 0 => 3.213f,
        >= 0 and < 1000 => 0.5f,
        < 5000 => 1.621f,
        >= 5000 => 2.475f
    };

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) * balance / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = default;
        for (years = 0; balance < targetBalance; years++)
        {
            balance += Interest(balance);
        }
        return years;
    }
}