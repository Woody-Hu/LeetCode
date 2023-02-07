using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class design_authentication_manager
	{
        public class AuthenticationManager
        {
            private int _ttl;

            private Dictionary<string, int> _dict = new Dictionary<string, int>();

            public AuthenticationManager(int timeToLive)
            {
                _ttl = timeToLive;
            }

            public void Generate(string tokenId, int currentTime)
            {
                _dict[tokenId] = currentTime;
            }

            public void Renew(string tokenId, int currentTime)
            {
                if (_dict.TryGetValue(tokenId, out var time))
                {
                    if (time + _ttl > currentTime)
                    {
                        _dict[tokenId] = currentTime;
                    }
                }
            }

            public int CountUnexpiredTokens(int currentTime)
            {
                var res = 0;
                foreach (var item in _dict)
                {
                    if (item.Value < currentTime && item.Value + _ttl > currentTime)
                    {
                        res++;
                    }
                }

                return res;
            }
        }
    }
}

