using System;
namespace LeetCode
{
    public class minimum_number_of_moves_to_seat_everyone
    {
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            var res = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                res += Math.Abs(seats[i] - students[i]);
            }

            return res;
        }
    }
}
