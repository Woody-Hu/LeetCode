using System.Collections.Generic;

namespace LeetCode;

public class strong_password_checker_ii
{
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length < 8)
        {
            return false;
        }
        
        var specials = new HashSet<char>() {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'};
        var n = password.Length;
        var hasLower = false;
        var hasUpper = false;
        var hasDigit = false;
        var hasSpecial = false;
        for (var i = 0; i < n; ++i) {
            if (i != n - 1 && password[i] == password[i + 1]) {
                return false;
            }

            var ch = password[i];
            if (char.IsLower(ch)) {
                hasLower = true;
            } else if (char.IsUpper(ch)) {
                hasUpper = true;
            } else if (char.IsDigit(ch)) {
                hasDigit = true;
            } else if (specials.Contains(ch)) {
                hasSpecial = true;
            }
        }

        return hasLower && hasUpper && hasDigit && hasSpecial;
    }
}