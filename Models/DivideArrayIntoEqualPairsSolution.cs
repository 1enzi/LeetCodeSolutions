using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class DivideArrayIntoEqualPairsSolution : ISolution
    {
        public void Solve()
        {
            int[] nums = [3, 2, 3, 2, 2, 2];

            var result = DivideArray(nums);

            Console.WriteLine(result);
        }

        public bool DivideArray(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);
                else
                    dict[num]++;

                if (dict[num] % 2 == 0)
                {
                    pairs++;
                }
            }

            return pairs == nums.Length / 2;
        }
    }
}
