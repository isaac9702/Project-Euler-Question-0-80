using System.Numerics;
List<BigInteger> factorials = new List<BigInteger> { 1, 1 };
int count = 0;
for (int n = 2; n <= 100; n++)
{
    factorials.Add(factorials[n - 1] * n);
    for (int r = 1; r <= n; r++)
    {
        BigInteger ways = factorials[n] / (factorials[r] * factorials[n - r]);
        if (ways > 1000000)
        {
            count++;
        }
    }
}
Console.Write(count);