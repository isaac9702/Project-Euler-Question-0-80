int limit = 1500000;
int[] count = new int[limit + 1];
int mLimit = (int)Math.Sqrt(limit / 2);

for (int m = 2; m <= mLimit; m++)
{
    for (int n = 1; n < m; n++)
    {
        if ((m + n) % 2 == 1 && GCD(m, n) == 1)
        {
            int primitivePerimeter = 2 * m * (m + n);
            for (int perimeter = primitivePerimeter; perimeter <= limit; perimeter += primitivePerimeter)
            {
                count[perimeter]++;
            }
        }
    }
}
int singleSolutionCount = 0;
for (int i = 0; i <= limit; i++)
{
    if (count[i] == 1)
    {
        singleSolutionCount++;
    }
}
Console.WriteLine(singleSolutionCount);

static int GCD(int a, int b)
{
while (b != 0)
{
    int temp = b;
    b = a % b;
    a = temp;
}
return a;
}
