using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class yong_liang_ge_zhan_shi_xian_dui_lie_lcof
{
    public class CQueue {
        
        private Stack<int> _a = new Stack<int>();
        
        private Stack<int> _b = new Stack<int>();

        public CQueue() {

        }
    
        public void AppendTail(int value) {
            _a.Push(value);
        }
    
        public int DeleteHead() {
            if (_b.Any())
            {
                return _b.Pop();
            }

            if (!_a.Any())
            {
                return -1;
            }
            
            while (_a.Any())
            {
                _b.Push(_a.Pop());
            }

            return _b.Pop();
        }
    }
}