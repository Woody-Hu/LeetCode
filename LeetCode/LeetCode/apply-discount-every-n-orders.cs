using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class apply_discount_every_n_orders
	{
        public class Cashier
        {
            private Dictionary<int, int> _dic = new Dictionary<int, int>();
            private int _count = 0;
            private int _discount = 0;
            private int _n = 0;

            public Cashier(int n, int discount, int[] products, int[] prices)
            {
                _n = n;
                _discount = discount;
                for (int i = 0; i < products.Length; i++)
                {
                    _dic[products[i]] = prices[i];
                }
            }

            public double GetBill(int[] product, int[] amount)
            {
                _count++;
                var res = 0.0d;
                for (int i = 0; i < product.Length; i++)
                {
                    res += _dic[product[i]] * amount[i];
                }

                if (_count == _n)
                {
                    _count = 0;
                    res -= res * _discount / 100.0d;
                }

                return res;
            }
        }
    }
}

