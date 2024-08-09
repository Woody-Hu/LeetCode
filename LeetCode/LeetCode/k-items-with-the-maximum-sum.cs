namespace LeetCode;

public class k_items_with_the_maximum_sum
{
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k) {
        if (k <= numOnes)
        {
            return k;
        }
        else if(k <= numOnes + numZeros)
        {
            return numOnes;
        }
        else
        {
            return numOnes - (k - numOnes - numZeros);
        }
    }
}