using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Reformat_Date
    {
        private Dictionary<string, string> _month = new Dictionary<string, string>()
        {
            { "Jan", "01"},
            { "Feb", "02"},
            { "Mar", "03"},
            { "Apr", "04"},
            { "May", "05"},
            { "Jun", "06"},
            { "Jul", "07"},
            { "Aug", "08"},
            { "Sep", "09"},
            { "Oct", "10"},
            { "Nov", "11"},
            { "Dec", "12"},
        };

        public string ReformatDate(string date)
        {
            var splited = date.Split(" ");
            var year = splited[2];
            var month = _month[splited[1]];
            var dateString = splited[0].Substring(0, splited[0].Length - 2);

            if (dateString.Length < 2)
            {
                dateString = "0" + dateString;
            }

            return $"{year}-{month}-{dateString}";
        }
    }
}
