int ans = 0; 
for (int n = 1; n <= 1000; n++) 
{
    if (n % 3 == 0 || n % 5 == 0) 
    {
        ans += n;
    }
} 
Console.Write(ans);