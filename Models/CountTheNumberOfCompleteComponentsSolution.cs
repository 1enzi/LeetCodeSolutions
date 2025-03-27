using LeetCodeSolutions.Models.Interfaces;

namespace LeetCodeSolutions.Models
{
    internal class CountTheNumberOfCompleteComponentsSolution : ISolution
    {
        public void Solve()
        {
            int[][] edges = [[0, 1], [0, 2], [1, 2], [3, 4]];
            int n = 6;

            var result = CountCompleteComponents(n, edges);

            Console.WriteLine(result);
        }

        public int CountCompleteComponents(int n, int[][] edges)
        {
            var graph = new List<int>[n];

            for (int i = 0; i < n; i++)
                graph[i] = new List<int>();

            for (var i = 0; i < edges.Length; i++)
            {
                graph[edges[i][0]].Add(edges[i][1]);
                graph[edges[i][1]].Add(edges[i][0]);
            }

            var count = 0;
            var visited = new bool[n];

            for (var i = 0; i < n; i++)
                if (!visited[i])
                {
                    var ncnt = 0;

                    if (Dfs(i, graph[i].Count, ref ncnt) && ncnt == graph[i].Count + 1)
                        count++;
                }

            return count;

            bool Dfs(int node, int cnt, ref int ncnt)
            {
                if (visited[node])
                    return true;

                ncnt++;

                visited[node] = true;

                var res = graph[node].Count == cnt;

                for (var i = 0; i < graph[node].Count; i++)
                    res &= Dfs(graph[node][i], cnt, ref ncnt);

                return res;
            }
        }
    }
}
