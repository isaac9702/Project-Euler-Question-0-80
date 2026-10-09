using System.Numerics;
BigInteger num = 1; 
for (BigInteger n = 1; n <= 100; n++)
{
    num*=n; 
}
char[] digits = num.ToString().ToCharArray(); 
int ans = 0; 
for (int i = 0; i < digits.Length;i++) 
{ 
    ans += int.Parse(digits[i].ToString());
} 
Console.Write(ans);