using System;
namespace LeetCode
{
    public class convert_the_temperature
    {
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15d, celsius * 1.80d + 32.00d };
        }
    }
}
