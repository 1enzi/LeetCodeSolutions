using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    public class MinimumTimeToRepairCarsSolution : ISolution
    {
        public void Solve()
        {
            int[] ranks = [4, 2, 3, 1];
            int cars = 10;

            var result = RepairCars(ranks, cars);

            Console.WriteLine(result);
        }

        public long RepairCars(int[] ranks, int cars)
        {
            long min = 1;
            long max = ranks.Min() * (long)cars * cars;

            while (min < max)
            {
                long mid = min + (max - min) / 2;
                if (CanBeRepaired(mid))
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return min;

            bool CanBeRepaired(long mid)
            {
                long repaired = 0;

                foreach (int i in ranks)
                {
                    long canRepair = (long)Math.Sqrt(mid / i);
                    repaired += canRepair;

                    if (repaired >= cars)
                        return true;
                }

                return false;
            }
        }
    }
}
