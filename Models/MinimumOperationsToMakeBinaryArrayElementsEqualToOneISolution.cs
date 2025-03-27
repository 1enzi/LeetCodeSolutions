using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    internal class MinimumOperationsToMakeBinaryArrayElementsEqualToOneISolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [0, 1, 1, 1, 0, 0];

            var result = MinOperations(nums);

            Console.WriteLine(result);
        }

        public int MinOperations(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i + 1] ^= 1;
                    nums[i + 2] ^= 1;
                    count++;
                }
            }
            return (nums[^1] & nums[^2]) == 1 ? count : -1;
        }
    }
}
