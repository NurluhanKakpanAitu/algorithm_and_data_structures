class Program
{
    static void Main()
    {
        string[] details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];
        Console.WriteLine(CountSeniors(details));
    }

    private static int CountSeniors(string[] details)
    {
        var count = 0;

        foreach (var detail in details)
        {
            var age = detail.Substring(11, 2);
            if (int.Parse(age) > 60)
                count++;
        }

        return count;
    }
}