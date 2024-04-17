namespace LeetCode;

public class count_symmetric_integers
{
    public int CountSymmetricIntegers(int low, int high)
    {
        var res = 0;
        for (int i = low; i <= high; i++)
        {
            var array = i.ToString().ToCharArray();
            var n = array.Length;
            if (n % 2 > 0)
            {
                continue;
            }

            var sum = 0;
            for (int j = 0; j < n / 2; j++)
            {
                sum += array[j];
            }

            for (int j = n/2; j < n; j++)
            {
                sum -= array[j];
            }
            
            if (sum == 0)
            {
                res++;
            }

        }

        return res;

    }
}