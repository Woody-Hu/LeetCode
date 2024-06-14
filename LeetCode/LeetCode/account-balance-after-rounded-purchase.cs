namespace LeetCode;

public class account_balance_after_rounded_purchase
{
    public int AccountBalanceAfterPurchase(int purchaseAmount)
    {
        var temp = purchaseAmount % 10;
        if ( temp >= 5)
        {
            purchaseAmount += 10 - temp;
        }
        else
        {
            purchaseAmount -= temp;
        }
        
        return 100 - purchaseAmount;

    }
}