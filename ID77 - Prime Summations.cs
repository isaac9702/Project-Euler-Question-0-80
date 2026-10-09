int targetLimit = 1000;
int[] ways = new int[targetLimit + 1];
ways[0] = 1;
List<int> primes = GeneratePrimes(targetLimit);

foreach (int prime in primes)
{
    for (int i = prime; i <= targetLimit; i++)
    {
        ways[i] += ways[i - prime];
    }
}
for (int i = 2; i <= targetLimit; i++)
{
    if (ways[i] > 5000)
    {
        Console.WriteLine(i);
        break;
    }
}

static List<int> GeneratePrimes(int limit)
{
    bool[] isPrime = new bool[limit + 1];
    Array.Fill(isPrime, true);
    isPrime[0] = false;
    isPrime[1] = false;

    for (int i = 2; i * i <= limit; i++)
    {
        if (isPrime[i])
        {
            for (int j = i * i; j <= limit; j += i)
            {
                isPrime[j] = false;
            }
        }
    }

    List<int> primes = new List<int>();
    for (int i = 2; i <= limit; i++)
    {
        if (isPrime[i])
        {
            primes.Add(i);
        }
    }
    return primes;
}