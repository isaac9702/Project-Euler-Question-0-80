int maxD = 1000000;
long bestN = 0;
long bestD = 1;

for (int d = 1; d <= maxD; d++)
{
    if (d % 7 == 0) 
    {
        continue;
    }
    long n = (3L * d - 1) / 7;
    if (n * bestD > bestN * d)
    {
        bestN = n;
        bestD = d;
    }
}
Console.WriteLine(bestN);
