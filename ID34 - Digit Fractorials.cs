long ans = 0;
long[] factorials = new long[10]; 
for (int i = 0; i < 10; i++)
{
    long product = 1;
    for (int j = 1; j <= i; j++)
    {
        product *= j;
    }
    factorials[i] = product;
}
for (long n = 3; n < 2540160; n ++)
{
    string number = n.ToString(); 
    char[] digits = number.ToCharArray(); 
    long sum = 0;
    for (int i = 0; i<digits.Length;i++)
    { 
        sum += factorials[digits[i] - '0'];

    }
    if (sum == n)
    {
        ans += sum;
    }
}
Console.Write(ans);