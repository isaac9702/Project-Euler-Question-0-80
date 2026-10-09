int limit = 1_000_000;
long[] phi = new long[limit + 1];
for (int i = 0; i <= limit; i++)
{
    phi[i] = i;
}

for (int i = 2; i <= limit; i++)
{
    if (phi[i] == i) 
    {
        for (int j = i; j <= limit; j += i)
        {
            phi[j] -= phi[j] / i;
        }
    }
}
long totalFractions = 0;
for (int d = 2; d <= limit; d++)
{
    totalFractions += phi[d];
}

Console.WriteLine(totalFractions);