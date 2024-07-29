class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(phi(7));
    }

    private static int phi(int n)
    {
        var result = n;
        for (var i = 2; i*i <= n; i++)
        {
            if (n % i == 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                }

                result -= result / i;
            }
        }

        if (n > 1)
        {
            result -= result / n;
        }

        return result;
    }
}

/*
Количество чисел от 1 до n, взаимно простых c n.
Свойства:
1. Если p- простое число, то количество p-1
2. Если p- простое, a- натуральное, количество p^a = p^a -p^(a-1)
3. Если a и b взаимно простые, то количество a*b = (количество a) * (количество b)
*/