using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Defanging_an_IP_Address
    {
        public string DefangIPaddr(string address)
        {
            var array = address.Split('.');

            var sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                if (i != array.Length - 1)
                {
                    sb.Append("[.]");
                }
            }

            return sb.ToString();
        }
    }
}
