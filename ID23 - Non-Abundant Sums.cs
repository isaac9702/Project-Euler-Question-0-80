long[] abundant = Array.Empty<long>();
long ans = 0;
for (long n = 1; n<=28123; n++)
{
    long sum = 0;
    for (long a = 1; a < n ; a++)
    {
        if (n%a == 0)
        {
            sum += a; 
        }
    }
    if (sum > n)
    {
        abundant = abundant.Append(n).ToArray();
    } 
    bool add = false;
    for (int i = 0; i<abundant.Length;i++)
    {
        for (int b = i; b<abundant.Length;b++)
        {
            if (abundant[i]+abundant[b] == n)
            {
                add = true; 
                break;
            }
        }
    }
    if (add == false)
    {
        ans += n;
    }
} 
Console.Write(ans); 

