class Program
{
    static void Main(string[] args)
    {
        string[] arr = ["a","b","a"];
        var k = 3;
        Console.WriteLine(KthDistinct(arr, k));
    }
    public static string KthDistinct(string[] arr, int k)
    {
        var resDic = new Dictionary<string, int>();

        foreach (var item in arr)
        {
            if (resDic.ContainsKey(item))
            {
                resDic[item]++;
                continue;
            }

            resDic[item] = 1;
        }

        resDic = resDic.Where(q => q.Value == 1).ToDictionary();
        if (resDic.Keys.Count < k)
            return "";

        return resDic.Keys.ToArray()[k - 1];

    }
}