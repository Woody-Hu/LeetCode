using System;
namespace LeetCode
{
    public class design_browser_history
    {
        public class BrowserHistory
        {
            private string[] _history;
            private int _current;
            private int _range;

            public BrowserHistory(string homepage)
            {
                _history = new string[5000];
                _current = -1;
                Visit(homepage);
            }

            public void Visit(string url)
            {
                _history[++_current] = url;
                _range = _current;
            }

            public string Back(int steps)
            {
                _current = Math.Max(0, _current - steps);
                return _history[_current];
            }

            public string Forward(int steps)
            {
                _current = Math.Min(_range, _current + steps);
                return _history[_current];
            }
        }
    }
}
