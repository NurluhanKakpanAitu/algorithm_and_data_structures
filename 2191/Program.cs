using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var mapping = new int[] { 8, 9, 4, 0, 2, 1, 3, 5, 7, 6 };
        var nums = new int[] { 991, 338, 38 };
        var res = SortJumbled(mapping, nums);
        foreach (var el in res)
        {
            Console.WriteLine(el);
        }
    }


    public static int[] SortJumbled(int[] mapping, int[] nums)
    {
        var resDic = new List<KeyValuePair<int, int>>();
        foreach (var num in nums)
        {
            var stringBuilder = new StringBuilder();
            var numString = num.ToString();

            foreach (var el in numString)
            {
                var elToInt = int.Parse(el.ToString());
                stringBuilder.Append(mapping[elToInt]);
            }

            resDic.Add(new KeyValuePair<int, int>(num, int.Parse(stringBuilder.ToString())));
        }

        
        var result = resDic.OrderBy(q => q.Value).Select(q => q.Key).ToArray();
        return result;
    }
}