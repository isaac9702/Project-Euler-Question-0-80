int limit = 10_000_000;
double minRatio = double.MaxValue;
long bestN = 0;

List<int> primes = GetPrimes(4000);
for (int i = 0; i < primes.Count; i++)
{
    for (int j = i + 1; j < primes.Count; j++)
    {
        long n = (long)primes[i] * primes[j];
        if (n >= limit) 
        {
            break;
        }
        long phi = (long)(primes[i] - 1) * (primes[j] - 1);
        double ratio = (double)n / phi;
        if (ratio < minRatio && IsPermutation(n, phi))
        {
            minRatio = ratio;
            bestN = n;
        }
    }
}
Console.WriteLine(bestN);

static bool IsPermutation(long a, long b)
{
    int[] count = new int[10];
    while (a > 0)
    {
        count[a % 10]++;
        a /= 10;
    }
    while (b > 0)
    {
        count[b % 10]--;
        b /= 10;
    }
    for (int i = 0; i < 10; i++)
    {
        if (count[i] != 0) 
            return false;
    }

    return true;
}

static List<int> GetPrimes(int max)
{
    bool[] isPrime = new bool[max + 1];
    Array.Fill(isPrime, true);
    isPrime[0] = isPrime[1] = false;
    for (int p = 2; p * p <= max; p++)
    {
        if (isPrime[p])
        {
            for (int i = p * p; i <= max; i += p)
                isPrime[i] = false;
        }
    }
    List<int> primes = [];
    for (int i = 2; i <= max; i++)
    {
        if (isPrime[i]) 
            primes.Add(i);
    }
    return primes;
}