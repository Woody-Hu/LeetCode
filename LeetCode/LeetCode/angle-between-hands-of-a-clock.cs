using System;
namespace LeetCode
{
    public class angle_between_hands_of_a_clock
    {
        public double AngleClock(int hour, int minutes)
        {
            var a1 = 6;
            var a2 = 30;
            double minutesAngle = a1 * minutes;
            double hourAngle = (hour % 12 + minutes / 60.0d) * a2;
            double diff = Math.Abs(hourAngle - minutesAngle);
            return Math.Min(diff, 360 - diff);

        }
    }
}

