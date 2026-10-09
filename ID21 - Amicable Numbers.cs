int ans = 0;
for (int n = 1; n <10000; n++)
{
    int sum = 0;
    for (int a = 1; a < n ; a++)
    {
        if (n%a == 0)
        {
            sum += a; 
        }
    }
    int sum2 = 0;
    for (int i = 1; i<sum; i++)
    {
        if (sum%i ==0)
        {
            sum2 += i; 
        }
    } 
    if (sum2 == n && n!=sum)
    {
        ans+= n;
    }
}
Console.Write(ans);