long[] primes = [2,3,5,7,11,13]; 
long ans = 2+3+5+7+11+13;
for (long n = 17; n <=2000000; n++)
{
    bool prime = true;
    for (int i = 0; i < primes.Length; i++) 
    {
        if (n%primes[i] == 0)
        {
            prime = false;
            break;
        }
    } 
    if (prime == true)
    { 
        primes = primes.Append(n).ToArray();
        ans += n;
    }
}

Console.Write(ans);