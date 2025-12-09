using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class total_waviness_of_numbers_in_range_i
    {
        public int TotalWaviness(int num1, int num2)
        {
            // 定义计算单个数字波动值的委托方法
            Func<int, int> calc = (int x) =>
            {
                // 提取数字的每一位（逆序存储，和C++逻辑一致）
                List<int> vec = new List<int>();
                while (x > 0)
                {
                    vec.Add(x % 10);
                    x /= 10;
                }

                int sz = vec.Count;
                int ret = 0;
                // 遍历中间位（排除首尾，因为需要前后都有数字）
                for (int i = 1; i + 1 < sz; i++)
                {
                    // 峰：当前位大于左右两侧
                    if (vec[i] > vec[i - 1] && vec[i] > vec[i + 1])
                        ret++;
                    // 谷：当前位小于左右两侧
                    if (vec[i] < vec[i - 1] && vec[i] < vec[i + 1])
                        ret++;
                }
                return ret;
            };

            // 遍历区间内所有数字，累加波动值
            int ans = 0;
            for (int i = num1; i <= num2; i++)
            {
                ans += calc(i);
            }
            return ans;
        }
    }
}
