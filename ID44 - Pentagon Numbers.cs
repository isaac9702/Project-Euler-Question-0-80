HashSet<long> pentagonSet = new HashSet<long>();
List<long> pentagonList = new List<long>();
bool found = false;
long k = 1;
while (found == false)
{
    long pk = k * (3 * k - 1) / 2;

    for (int j = pentagonList.Count - 1; j >= 0; j--)
    {
        long pj = pentagonList[j];
        long diff = pk - pj;
        long sum = pk + pj;

        if (pentagonSet.Contains(diff) && IsPentagonal(sum))
        {
            Console.WriteLine(diff);
            found = true;
            break;
        }
    }

    pentagonSet.Add(pk);
    pentagonList.Add(pk);
    k++;
}
static bool IsPentagonal(long x)
{
double val = (Math.Sqrt(1 + 24.0 * x) + 1) / 6.0;
return val == (long)val;
}
