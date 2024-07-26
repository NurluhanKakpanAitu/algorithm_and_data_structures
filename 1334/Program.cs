class Program
{
    static void Main(string[] args)
    {
        var n = 4;
        var edges = new int[][]
        {
            [0, 1, 3],
            [1, 2, 1],
            [1, 3, 4],
            [2, 3, 1]
        };
        var distanceThreshold = 4;

        var res = FindTheCity(n, edges, distanceThreshold);
        Console.WriteLine(res);
    }

    public static int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var dictionary = new Dictionary<int, int>();
        var matrix = new int[n,n];
        foreach (var array in edges)
        {
            var from_i = array[0];
            var to_i = array[1];
            var weight_i = array[2];
            matrix[from_i, to_i] = weight_i;
            matrix[to_i, from_i] = weight_i;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, j] = int.MaxValue;
                }

                if (i == j)
                    matrix[i, j] = 0;
            }
        }
        
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, k] != int.MaxValue && matrix[k, j] != int.MaxValue && matrix[i, k] + matrix[k, j] < matrix[i, j])
                    {
                        matrix[i, j] = matrix[i, k] + matrix[k, j];
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!dictionary.ContainsKey(i))
                    dictionary[i] = 0;

                if (matrix[i, j] <= distanceThreshold)
                    dictionary[i]++;
            }
        }

        return dictionary
            .OrderByDescending(q => q.Value)
            .ThenBy(q => q.Key)
            .Last().Key;
    }
    
    
    
    // Алгоритм Флойда которую найдет самую краткую путь между вершинами графа 
    // A1[i,j] = min(A0[i,j],A0[i,1] + A0[1,j])
    
}