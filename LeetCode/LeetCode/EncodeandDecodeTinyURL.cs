using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class EncodeandDecodeTinyURL
    {
        private List<string> useValue = new List<string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
  
            useValue.Add(longUrl);
            return (useValue.Count - 1).ToString();
        
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            int tempValue = int.Parse(shortUrl);
            return tempValue > useValue.Count - 1 ? string.Empty : useValue[tempValue];
        }
    }
}
