using System.Numerics;

BigInteger maxX = 0;
int resultD = 0;
for (int d = 2; d <= 1000; d++)
{
    int limitA0 = (int)Math.Sqrt(d);
    if (limitA0 * limitA0 == d)
    {
        continue;
    }
    int m = 0;
    int denom = 1;
    int a = limitA0;
    BigInteger pPrev2 = 0, pPrev1 = 1, p = limitA0;
    BigInteger qPrev2 = 1, qPrev1 = 0, q = 1;
    while (p * p - d * q * q != 1)
    {
        m = denom * a - m;
        denom = (d - m * m) / denom;
        a = (limitA0 + m) / denom;
        pPrev2 = pPrev1;
        pPrev1 = p;
        p = a * pPrev1 + pPrev2;
        qPrev2 = qPrev1;
        qPrev1 = q;
        q = a * qPrev1 + qPrev2;
    }
    if (p > maxX)
    {
        maxX = p;
        resultD = d;
    }
}
Console.WriteLine(resultD);