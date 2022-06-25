using System;
namespace LeetCode
{
	public class design_parking_system
	{
        public class ParkingSystem
        {
            private int[] _data;

            public ParkingSystem(int big, int medium, int small)
            {
                _data = new int[3];
                _data[0] = big;
                _data[1] = medium;
                _data[2] = small;
            }

            public bool AddCar(int carType)
            {
                if (_data[carType] <= 0)
                {
                    return false;
                }

                _data[carType]--;
                return true;
            }
        }
    }
}

