List<int> primes = GeneratePrimes(10000);

for (int a = 0; a < primes.Count; a++)
{
    int p1 = primes[a];
    if (p1 == 2 || p1 == 5) continue;

    for (int b = a + 1; b < primes.Count; b++)
    {
        int p2 = primes[b];
        if (p2 == 5 || !IsPairValid(p1, p2)) continue;

        for (int c = b + 1; c < primes.Count; c++)
        {
            int p3 = primes[c];
            if (!IsPairValid(p1, p3) || !IsPairValid(p2, p3)) continue;

            for (int d = c + 1; d < primes.Count; d++)
            {
                int p4 = primes[d];
                if (!IsPairValid(p1, p4) || !IsPairValid(p2, p4) || !IsPairValid(p3, p4)) continue;

                for (int e = d + 1; e < primes.Count; e++)
                {
                    int p5 = primes[e];
                    if (!IsPairValid(p1, p5) || !IsPairValid(p2, p5) || !IsPairValid(p3, p5) || !IsPairValid(p4, p5)) continue;

                    int ans = p1 + p2 + p3 + p4 + p5;
                    Console.WriteLine(ans);
                    return;
                }
            }
        }
    }
}

static bool IsPairValid(int p1, int p2)
{
    return isPrime(p1.ToString() + p2.ToString()) && isPrime(p2.ToString() + p1.ToString());
}

static bool isPrime(string number)
{
    if (!long.TryParse(number, out long num)) return false;
    if (num < 2) return false;

    long limit = (long)Math.Floor(Math.Sqrt(num));
    for (long n = 2; n <= limit; n++)
    {
        if (num % n == 0) return false;
    }
    return true;
}

static List<int> GeneratePrimes(int limit)
{
    bool[] isPrime = new bool[limit + 1];
    Array.Fill(isPrime, true);
    isPrime[0] = isPrime[1] = false;
    for (int p = 2; p * p <= limit; p++)
    {
        if (isPrime[p])
        {
            for (int i = p * p; i <= limit; i += p)
                isPrime[i] = false;
        }
    }
    List<int> result = new List<int>();
    for (int i = 2; i <= limit; i++)
        if (isPrime[i]) result.Add(i);
    return result;
}