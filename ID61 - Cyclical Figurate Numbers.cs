List<int>[] numbers = new List<int>[6];
for (int i = 0; i < 6; i++)
{
    numbers[i] = new List<int>();
    int type = i + 3;
    int n = 1;
    while (true)
    {
        int p = type switch
        {
            3 => n * (n + 1) / 2,
            4 => n * n,
            5 => n * (3 * n - 1) / 2,
            6 => n * (2 * n - 1),
            7 => n * (5 * n - 3) / 2,
            8 => n * (3 * n - 2),
            _ => 0
        };

        if (p >= 10000) break;
        if (p >= 1000 && p % 100 >= 10) numbers[i].Add(p);
        n++;
    }
}
int totalSum = 0;
bool[] usedTypes = new bool[6];
List<int> chain = new List<int>();
foreach (int oct in numbers[5])
{
    usedTypes[5] = true;
    chain.Add(oct);
    if (Search(oct, oct, 1)) break;
    chain.RemoveAt(chain.Count - 1);
    usedTypes[5] = false;
}
Console.WriteLine(totalSum);

bool Search(int startNum, int currentNum, int depth)
{
    if (depth == 6)
    {
        if (currentNum % 100 == startNum / 100)
        {
            foreach (int val in chain) 
            {
                totalSum += val;
            }
            return true;
        }
        return false;
    }

    int suffix = currentNum % 100;

    for (int t = 0; t < 5; t++)
    {
        if (usedTypes[t]) continue;

        foreach (int nextNum in numbers[t])
        {
            if (nextNum / 100 == suffix)
            {
                usedTypes[t] = true;
                chain.Add(nextNum);

                if (Search(startNum, nextNum, depth + 1)== true) 
                { 
                    return true;
                }

                chain.RemoveAt(chain.Count - 1);
                usedTypes[t] = false;
            }
        }
    }
    return false;
}