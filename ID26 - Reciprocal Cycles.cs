int maxCount = 0;
int bestD = 0;

for (int d = 999; d > 1; d--)
{
    if (maxCount >= d) break;

    int[] lastPosition = new int[d];
    int remainder = 1;
    int position = 1; 
    while (remainder != 0 && lastPosition[remainder] == 0)
    {
        lastPosition[remainder] = position;
        remainder = (remainder * 10) % d;
        position++;
    }
    if (remainder != 0)
    {
        int cycleLength = position - lastPosition[remainder];
        
        if (cycleLength > maxCount)
        {
            maxCount = cycleLength;
            bestD = d;
        }
    }
}
Console.Write(bestD);