using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class LongestNiceSubarraySolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [1, 3, 8, 48, 10];

            var result = LongestNiceSubarray(nums);

            Console.WriteLine(result);
        }

        public int LongestNiceSubarray(int[] nums)
        {
            int mask = 0, maxLength = 0, left = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while ((mask & nums[i]) != 0)
                {
                    mask ^= nums[left];
                    left++;
                }

                mask |= nums[i];
                maxLength = Math.Max(maxLength, i - left + 1);
            }

            return maxLength;
        }
    }
}
