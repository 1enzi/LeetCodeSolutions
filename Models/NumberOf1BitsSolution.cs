using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    internal class NumberOf1BitsSolution : ISolution
    {
        public void Solve()
        {
            int n = 11;

            var result = HammingWeight(n);

            Console.WriteLine(result);
        }

        public int HammingWeight(int n)
        {
            int bits = 0;

            while (n > 0)
            {
                if (n % 2 == 1)
                    bits++;

                n >>= 1;
            }
            return bits;
        }
    }
}
