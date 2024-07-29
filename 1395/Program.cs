class Program
{
    static void Main(string[] args)
    {
        var rating = new int[] { 2,1,3 };
        var res = NumTeams(rating);
        Console.WriteLine(res);
    }

    private static int NumTeams(int[] rating)
    {
        var count = 0;

        for (int i = 0; i < rating.Length-2; i++)
        {
            for (int j = i; j < rating.Length - 1; j++)
            {
                for (int k = j; k < rating.Length; k++)
                {
                    if (i < j && j < k)
                    {
                        if (rating[i] < rating[j] && rating[j] < rating[k])
                            count++;

                        if (rating[i] > rating[j] && rating[j] > rating[k])
                            count++;
                    }
                }
            }
        }

        return count;
    }
}