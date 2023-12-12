using System;
namespace LeetCode
{
	public class count_tested_devices_after_test_operations
	{
        public int CountTestedDevices(int[] batteryPercentages)
        {
            var res = 0;
            foreach (var item in batteryPercentages)
            {
                if (item - res > 0)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

