using System;
namespace LeetCode
{
	public class maximize_the_confusion_of_an_exam
	{
        public int MaxConsecutiveAnswers(string answerKey, int k)
        {
            return Math.Max(WindowCalculate(answerKey, k, 'T'), WindowCalculate(answerKey, k, 'F'));
        }

        private int WindowCalculate(string answerKey, int k, char predict)
        {
            var n = answerKey.Length;
            var res = 0;
            var left = 0;
            var right = 0;
            var sum = 0;
            for (;  right < n; right++)
            {
                sum += answerKey[right] != predict ? 1 : 0;
                while (sum > k)
                {
                    sum -= answerKey[left++] != predict ? 1 : 0;
                }

                res = Math.Max(res, right - left + 1);
            }

            return res;
        }
    }
}

