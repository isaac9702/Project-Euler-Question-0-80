using System.Numerics; 
BigInteger sum = BigInteger.Pow(2,1000); 
string number = sum.ToString();
char[] digits = number.ToCharArray(); 
int ans = 0;
for (int n = 0; n< digits.Length;n++)
{
    ans += int.Parse(digits[n].ToString());
}
Console.Write(ans); 
