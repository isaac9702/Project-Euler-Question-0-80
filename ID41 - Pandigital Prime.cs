static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
}
static bool IsPandigital(int number) 
{
    string s = number.ToString();
    for (int i = 1; i <= s.Length; i++)
    {
        if (!s.Contains(i.ToString())) 
        {return false;}
    }

    return true;
}
int biggest = 0;
for (int i = 1; i<10000000;i++)
{
    if (IsPrime(i) == true && IsPandigital(i) == true)
    {
        if (i > biggest)
        {
            biggest = i; 
        }
    }
}
Console.Write(biggest);