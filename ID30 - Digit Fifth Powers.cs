int upperLimit = 6 * (int)Math.Pow(9, 5); 
int ans = 0;
for (int i = 10; i<upperLimit;i++)
{
    string number = i.ToString(); 
    char[] digits = number.ToCharArray(); 
    int sum = 0;
    for (int n = 0; n< digits.Length;n++)
    {
        int digit = (int)Char.GetNumericValue(digits[n]); 
        int power = (int)Math.Pow(digit, 5); 
        sum += power; 
    }
    if (sum == i)
    {
        ans += i;
    }
}
Console.Write(ans);