using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class logger_rate_limiter
    {
        public logger_rate_limiter()
        {
        }

        public class Logger
        {
            private Dictionary<string, int> _dict = new Dictionary<string, int>();

            public Logger()
            {

            }

            public bool ShouldPrintMessage(int timestamp, string message)
            {
                if (!_dict.TryGetValue(message, out var exist))
                {
                    _dict.Add(message, timestamp);
                    return true;
                }

                if (timestamp - exist >= 10)
                {
                    _dict[message] = timestamp;
                    return true;
                }

                return false;
            }
        }
    }
}
