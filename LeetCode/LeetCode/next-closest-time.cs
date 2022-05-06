using System;
namespace LeetCode
{
    public class next_closest_time
    {
        public string NextClosestTime(string time)
        {
            var values = new int[4];
            values[0] = Int32.Parse(time[0].ToString());
            values[1] = Int32.Parse(time[1].ToString());
            values[2] = Int32.Parse(time[3].ToString());
            values[3] = Int32.Parse(time[4].ToString());
            var currentMinutes = (values[0] * 10 + values[1]) * 60 + values[2] * 10 + values[3];
            int minMinute = 24 * 60;
            string result = "00:00";
            for (int i = 0; i < 4; i++)
            {
                if (values[i] > 2)
                    continue;

                for (int j = 0; j < 4; j++)
                {
                    if (values[i] * 10 + values[j] > 23)
                        continue;

                    for (int k = 0; k < 4; k++)
                    {
                        if (values[k] > 5)
                            continue;

                        for (int l = 0; l < 4; l++)
                        {
                            int _tempMinute = (values[i] * 10 + values[j]) * 60 + values[k] * 10 + values[l] - currentMinutes;
                            if (_tempMinute <= 0)
                                _tempMinute += 24 * 60;

                            if (_tempMinute <= minMinute)
                            {
                                minMinute = _tempMinute;
                                result = values[i].ToString() + values[j].ToString() + ":" + values[k].ToString() + values[l].ToString();
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
