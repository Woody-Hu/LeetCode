using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class validate_ip_address
	{
		public string ValidIPAddress(string queryIP)
		{
            if (queryIP.Count(k => k == '.') == 3)
            {
				return ValidIPv4(queryIP.Split('.'));
            }
            else if (queryIP.Count(k => k == ':') == 7)
            {
				return ValidIPv6(queryIP.Split(':'));
            }

			return "Neither";
		}

		private string ValidIPv4(IEnumerable<string> splited)
		{
            foreach (var item in splited)
            {
                if (item.Length == 0)
                {
					return "Neither";
				}
                else if (!int.TryParse(item, out var itemInt))
                {
					return "Neither";
				}
                else if (itemInt.ToString().Length != item.Length)
                {
					return "Neither";
				}
                else if (itemInt < 0 || itemInt > 255)
                {
					return "Neither";
				}
            }

			return "IPv4";
		}

		private string ValidIPv6(IEnumerable<string> splited)
		{
			var set = "0123456789abcdefABCDEF".ToHashSet();
            foreach (var item in splited)
            {
                if (item.Length == 0 || item.Length > 4)
                {
					return "Neither";
				}
                else if (item.Any( k => !set.Contains(k)))
                {
					return "Neither";
				}
            }

			return "IPv6";
		}
	}
}

