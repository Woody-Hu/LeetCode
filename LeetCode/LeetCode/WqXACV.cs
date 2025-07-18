using System.Linq;

namespace LeetCode;

public class WqXACV
{
    public int HalfQuestions(int[] questions) 
    {
        int n = questions.Length / 2;
        var query = from q in questions 
            group q by q into qGroup 
            orderby qGroup.Count() descending 
            select qGroup.Count();
        int sum = 0;
        int count = 0;
        foreach (var q in query)
        {
            sum += q;
            count ++;
            if (sum >= n) break;
        }
        return count;        
    }
}