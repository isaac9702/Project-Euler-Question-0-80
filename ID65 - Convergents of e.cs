using System.Numerics;

int targetTerm = 100;
BigInteger pPrev2 = 1; // p_{-1}
BigInteger pPrev1 = 2; // p_0
BigInteger pCurrent = 0;
for (int i = 2; i <= targetTerm; i++)
{
    BigInteger a = (i % 3 == 0) ? 2 * (i / 3) : 1;
    pCurrent = a * pPrev1 + pPrev2;
    pPrev2 = pPrev1;
    pPrev1 = pCurrent;
}

int digitSum = 0;
foreach (char digit in pCurrent.ToString())
{
    digitSum += digit - '0';
}
Console.WriteLine(digitSum);