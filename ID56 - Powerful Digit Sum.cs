using System.Numerics;
int ans = 0;
for (int a = 1; a<100; a++)
{
    for (int b = 1; b<100; b++)
    {
        BigInteger num = BigInteger.Pow(a,b);
        char[] digits = num.ToString().ToCharArray(); 
        int sum = 0;
        for (int n = 0; n<digits.Length;n++)
        {
            sum+= digits[n] - '0';
        }
        if (sum>ans)
        {
            ans = sum;
        }
    }
}
Console.Write(ans);
