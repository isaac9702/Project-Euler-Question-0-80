int limit = 10000;
bool[] isPrime = PrecomputePrimes(limit);
List<int> primes = new List<int>();

for (int i = 2; i < limit; i++)
{
    if (isPrime[i]) primes.Add(i);
}

for (int n = 9; n < limit; n += 2)
{
    if (isPrime[n]) 
    {
        continue;
    }

    bool isSum = false;

    for (int k = 1; 2 * k * k < n; k++)
    {
        int remainder = n - 2 * k * k;
        if (isPrime[remainder])
        {
            isSum = true;
            break;
        }
    }

    if (!isSum)
    {
        Console.WriteLine(n);
        return;
    }
}


static bool[] PrecomputePrimes(int max)
{
bool[] isPrime = new bool[max];
Array.Fill(isPrime, true);
isPrime[0] = false;
isPrime[1] = false;

for (int i = 2; i * i < max; i++)
{
    if (isPrime[i])
    {
        for (int j = i * i; j < max; j += i)
        {
            isPrime[j] = false;
        }
    }
}
return isPrime;
}
