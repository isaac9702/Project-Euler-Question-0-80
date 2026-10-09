using System.Numerics;
BigInteger sum = 0;
for (BigInteger n = 1; n <= 1000; n++)
{
    sum += BigInteger.Pow(n,(int)n);
}
string number = sum.ToString();
string ans = number.Substring(number.Length-10,10); 
Console.Write(ans);