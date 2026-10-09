
long ans = 0;

for (long n = 1; n <= 642000; n++) 
{
    if (n % 2 != 0) 
    {
        ans += n * n;
    }
}

Console.Write(ans);
