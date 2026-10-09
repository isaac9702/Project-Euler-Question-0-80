using System.Numerics;

int totalDigitalSum = 0;

for (int n = 1; n <= 100; n++)
{
    int rootFloor = (int)Math.Sqrt(n);
    if (rootFloor * rootFloor == n) 
    { 
        continue; 
    }

    BigInteger scaledN = BigInteger.Parse(n + new string('0', 200));
    BigInteger root = IntegerSqrt(scaledN);
    string digits = root.ToString().Substring(0, 100);
    foreach (char c in digits)
    {
        totalDigitalSum += c - '0';
    }
}
Console.WriteLine(totalDigitalSum);

static BigInteger IntegerSqrt(BigInteger value)
{
    if (value == 0) return 0;

    BigInteger x = BigInteger.One << (int)(Math.Ceiling(BigInteger.Log(value, 2) / 2) + 1);
    while (true)
    {
        BigInteger y = (x + value / x) / 2;
        if (y >= x) return x;
        x = y;
    }
}