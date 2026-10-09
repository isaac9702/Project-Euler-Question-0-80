using System.Numerics;
int count = 0;
BigInteger numerator = 3;
BigInteger denominator = 2;
for (int i = 1; i <= 1000; i++)
{
    if (numerator.ToString().Length > denominator.ToString().Length)
    {
        count++;
    }
    BigInteger nextNumerator = numerator + (2 * denominator);
    BigInteger nextDenominator = numerator + denominator;
    numerator = nextNumerator;
    denominator = nextDenominator;
}
Console.WriteLine(count);
