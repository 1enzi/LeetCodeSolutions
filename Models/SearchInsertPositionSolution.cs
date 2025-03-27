using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class SearchInsertPositionSolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 5;

            var result = SearchInsert(nums, target);

            Console.WriteLine(result);
        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                    return i;
            }

            return nums.Length;
        }
    }
}
