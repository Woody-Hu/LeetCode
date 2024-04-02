namespace LeetCode;

public class water_bottles_ii
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        var res = numBottles;
        while (numBottles > numExchange)
        {
            res++;
            numBottles += 1 - numExchange++;
        }

        return res;
    }
}