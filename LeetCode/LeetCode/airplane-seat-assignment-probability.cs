using System;
namespace LeetCode
{
    public class airplane_seat_assignment_probability
    {
        public double NthPersonGetsNthSeat(int n)
        {
            return n == 1 ? 1 : 0.5;
        }
    }
}
