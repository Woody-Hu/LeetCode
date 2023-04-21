using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class filter_restaurants_by_vegan_friendly_price_and_distance
	{
        public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance)
        {
            var list = new List<int[]>();
            foreach (int[] restaurant in restaurants)
            {
                if ((restaurant[2] == 1 || veganFriendly == 0) && restaurant[3] <= maxPrice && restaurant[4] <= maxDistance)
                {
                    list.Add(new int[] { restaurant[0], restaurant[1] });
                }
            }

            list.Sort((a, b) => {
                if (a[1] != b[1])
                {
                    return b[1] - a[1];
                }
                else
                {
                    return b[0] - a[0];
                }
            });

            var res = new List<int>();
            foreach (var item in list)
            {
                res.Add(item[0]);
            }

            return res;
        }
    }
}

