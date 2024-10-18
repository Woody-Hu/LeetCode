using System.Collections.Generic;

namespace LeetCode;

public class shu_zu_zhong_zhong_fu_de_shu_zi_lcof
{
    public int FindRepeatDocument(int[] documents) {
        var set = new HashSet<int>();
        foreach (var document in documents)
        {
            if (set.Contains(document))
            {
                return document;
            }
            else
            {
                set.Add(document);
            }
        }

        return -1;
    }
}