int limit = 10000;
int oddPeriodCount = 0;
for (int n = 2; n <= limit; n++)
{
    int a0 = (int)Math.Sqrt(n);
    if (a0 * a0 == n) 
        continue;

    int period = 0;
    int m = 0;
    int d = 1;
    int a = a0;
    do
    {
        m = d * a - m;
        d = (n - m * m) / d;
        a = (a0 + m) / d;
        period++;
    } 
    while (a != 2 * a0);

    if (period % 2 != 0)
    {
        oddPeriodCount++;
    }
}
Console.WriteLine(oddPeriodCount);