using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class RomanToIntegerSolution : ISolution
    {
        public void Solve()
        {
            var roman = "MCMXCIV";
            var result = RomanToInt(roman);

            Console.WriteLine(result);
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> values = new Dictionary<char, int>()
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 },
        };

            int result = values[s[0]];
            for (int i = 1; i < s.Length; i++)
            {
                if (values[s[i - 1]] < values[s[i]])
                {
                    result += (-(values[s[i - 1]] * 2)) + values[s[i]];
                }
                else
                {
                    result += values[s[i]];
                }
            }
            return result;
        }
    }
}
