using System;
using System.Linq;

long num = 600851475143L; 
long divider = 2;
long[] factors = Array.Empty<long>();
while (num > 1)
{
    while (num % divider == 0)
    {
        num /= divider;
        factors = factors.Append(divider).ToArray();
    }
    divider++;
    if (divider * divider > num && num > 1)
    {
        factors = factors.Append(num).ToArray();
        break;
    }
}
if (factors.Length > 0)
{
    long largest = factors.Max(); 
    Console.Write(largest);
}