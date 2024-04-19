using System.Collections.Generic;

namespace LeetCode;

public class maximum_number_of_words_you_can_type
{
    public int CanBeTypedWords(string text, string brokenLetters) {
        var broken = new HashSet<char>(brokenLetters);
        var words = text.Split(' ');
        var count = 0;
        foreach(var word in words)
        {
            var canType = true;
            foreach(var c in word)
            {
                if(broken.Contains(c))
                {
                    canType = false;
                    break;
                }
            }
            if(canType)
            {
                count++;
            }
        }
        
        return count;

    }
}