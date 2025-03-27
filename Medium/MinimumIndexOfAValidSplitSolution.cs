using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Medium
{
    public class MinimumIndexOfAValidSplitSolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [3, 3, 3, 3, 7, 2, 2];

            var result = MinimumIndex(nums);

            Console.WriteLine(result);
        }

        public int MinimumIndex(IList<int> nums)
        {
            var dict = new Dictionary<int, int>();
            int dominator = 0, totalCount = 0, leftCount = 0;

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }

                if (dict[num] > totalCount)
                {
                    totalCount = dict[num];
                    dominator = num;
                }
            }

            if (totalCount * 2 <= nums.Count) 
                return -1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == dominator) 
                    leftCount++;

                int leftSize = i + 1;
                int rightSize = nums.Count - leftSize;

                if (leftCount * 2 > leftSize && (totalCount - leftCount) * 2 > rightSize)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
