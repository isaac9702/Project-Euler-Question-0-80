string ans = "";
foreach (var p in GetPermutations(Enumerable.Range(1, 10).ToArray()))
{
    int e0 = p[0], e1 = p[1], e2 = p[2], e3 = p[3], e4 = p[4];
    int i0 = p[5], i1 = p[6], i2 = p[7], i3 = p[8], i4 = p[9];

    if (e0 > e1 || e0 > e2 || e0 > e3 || e0 > e4)
        continue;

    int sum = e0 + i0 + i1;
    if (e1 + i1 + i2 != sum ||
        e2 + i2 + i3 != sum ||
        e3 + i3 + i4 != sum ||
        e4 + i4 + i0 != sum)
    {
        continue;
    }
    string candidate = $"{e0}{i0}{i1}{e1}{i1}{i2}{e2}{i2}{i3}{e3}{i3}{i4}{e4}{i4}{i0}";
    if (candidate.Length == 16 && string.Compare(candidate, ans) > 0)
    {
        ans = candidate;
    }
}
Console.WriteLine(ans);

static IEnumerable<int[]> GetPermutations(int[] list)
{
    return Permute(list, 0, list.Length - 1);

    static IEnumerable<int[]> Permute(int[] array, int start, int end)
    {
        if (start == end)
        {
            yield return (int[])array.Clone();
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                (array[start], array[i]) = (array[i], array[start]);
                foreach (var res in Permute(array, start + 1, end))
                    yield return res;
                (array[start], array[i]) = (array[i], array[start]);
            }
        }
    }
}