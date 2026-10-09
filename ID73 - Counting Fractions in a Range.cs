int limit = 12000;
int count = 0;

for (int d = 1; d <= limit; d++)
{
    int minN = d / 3 + 1;
    int maxN = (d - 1) / 2;
    for (int n = minN; n <= maxN; n++)
    {
        if (Gcd(n, d) == 1)
        {
            count++;
        }
    }
}
Console.WriteLine(count);

static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}