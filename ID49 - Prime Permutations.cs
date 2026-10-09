List<int> primes = GetPrimes(1000, 9999);
var groups = primes.GroupBy(p => new string(p.ToString().OrderBy(c => c).ToArray()));

foreach (var group in groups)
{
    List<int> list = group.OrderBy(x => x).ToList();
    if (list.Count < 3) continue;
    for (int i = 0; i < list.Count; i++)
    {
        for (int j = i + 1; j < list.Count; j++)
        {
            int diff = list[j] - list[i];
            int kVal = list[j] + diff;

            if (list.Contains(kVal) && list[i] != 1487)
            {
                string result = $"{list[i]}{list[j]}{kVal}";
                Console.WriteLine(result);
                return;
            }
        }
    }
}
static List<int> GetPrimes(int min, int max)
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

    List<int> result = new List<int>();
    for (int i = min; i <= max; i++)
    {
        if (isPrime[i]) result.Add(i);
    }
    return result;
}