using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class HouseRobberIVSolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [2, 3, 5, 9];
            int k = 2;

            var result = MinCapability(nums, k);

            Console.WriteLine(result);
        }

        public int MinCapability(int[] nums, int k)
        {
            int min = nums.Min();
            int max = nums.Max();

            while (min < max)
            {
                int mid = min + (max - min) / 2;

                if (CanSteal(mid, k, nums))
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }

            bool CanSteal(int m, int k, int[] nums)
            {
                var houses = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= m)
                    {
                        houses++;
                        i++;
                    }

                    if (houses == k)
                    {
                        return true;
                    }
                }

                return false;
            }

            return min;
        }
    }
}
