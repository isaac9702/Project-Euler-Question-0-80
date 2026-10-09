int highest = 0;
long ans = 0;
for (long n = 1; n < 1000000; n++)
{
    long num = n; 
    int count = 1;
    while (num != 1)
    {
        if (num%2==0)
        {
            num = num/2;
        }
        else
        {
            num = 3*num + 1; 
        }
        count++;
    }
    if (count>highest)
    {
        highest = count;
        ans = n;
    } 
}
Console.Write(ans);