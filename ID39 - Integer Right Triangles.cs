int maxSolutions = 0;
int bestP = 0;

for (int p = 2; p <= 1000; p += 2)
{
    int solutions = 0;
    for (int a = 1; a < p / 3; a++)
    {
        if ((p * (p - 2 * a)) % (2 * (p - a)) == 0)
        {
            solutions++;
        }
    }
    if (solutions > maxSolutions)
    {
        maxSolutions = solutions;
        bestP = p;
    }
}
Console.Write(bestP);