using System.Numerics;
static bool isPalindrome(BigInteger num)
{
    string number = num.ToString();
    string opposite = string.Concat(number.Reverse());
    BigInteger second = BigInteger.Parse(opposite);
    if (num == second)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int ans = 0;
for (BigInteger n = 1; n < 10000;n++)
{
    BigInteger first = n;
    BigInteger second = BigInteger.Parse(string.Concat(n.ToString().Reverse()));
    int count = 0;
    while (count<51)
    {
        BigInteger sum = first+second; 
        if (isPalindrome(sum)==true)
        {
            count = 100;
        }
        else
        {
            count++;
            first = sum; 
            second = BigInteger.Parse(string.Concat(first.ToString().Reverse()));
        }
    }
    if (count != 100)
    {
        ans++;
    }
}
Console.Write(ans);