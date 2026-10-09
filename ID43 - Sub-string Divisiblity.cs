static bool IsPandigital0To9(long num)
{
    string str = num.ToString();
    if (str.Length != 10) return false;
    
    for (char c = '0'; c <= '9'; c++)
    {
        if (!str.Contains(c)) return false;
    }
    return true;
}
long ans = 0;
int[] primes = [2, 3, 5, 7, 11, 13, 17];
for (long n = 1023456789L; n <= 9876543210L; n += 9)
{
    if (IsPandigital0To9(n))
    {
        string number = n.ToString();
        bool divisible = true;

        for (int i = 0; i < primes.Length; i++)
        {
            int sub = int.Parse(number.Substring(i + 1, 3));
            if (sub % primes[i] != 0)
            {
                divisible = false;
                break;
            }
        }

        if (divisible)
        {
            ans += n;
        }
    }
}
Console.Write(ans);