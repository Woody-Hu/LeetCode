using System.Text;

namespace LeetCode;

public class goal_parser_interpretation
{
    public string Interpret(string command) {
        var res = new StringBuilder();
        for (int i = 0; i < command.Length; i++) {
            if (command[i] == 'G') {
                res.Append("G");
            } else if (command[i] == '(') {
                if (command[i + 1] == ')') {
                    res.Append("o");
                } else {
                    res.Append("al");
                }
            }
        }
        
        return res.ToString();
    }
}