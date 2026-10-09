int limit = 100000;
int mod = 1000000;
int[] p = new int[limit];
p[0] = 1;

for (int n = 1; n < limit; n++)
{
    long currentP = 0;
    int k = 1;
    while (true)
    {
        int g1 = k * (3 * k - 1) / 2;
        int g2 = k * (3 * k + 1) / 2;
        if (g1 > n) 
        {
            break;
        }
        int sign = (k % 2 != 0) ? 1 : -1;
        currentP = (currentP + sign * p[n - g1]) % mod;
        if (g2 <= n)
        {
            currentP = (currentP + sign * p[n - g2]) % mod;
        }

        k++;
    }
    p[n] = (int)((currentP % mod + mod) % mod);
    if (p[n] == 0)
    {
        Console.WriteLine(n);
        break;
    }
}