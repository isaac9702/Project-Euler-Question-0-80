int limit = 1000000;
bool[] isPrime = new bool[limit + 1];
Array.Fill(isPrime, true);
isPrime[0] = false;
isPrime[1] = false;

for (int p = 2; p * p <= limit; p++)
{
    if (isPrime[p])
    {
        for (int i = p * p; i <= limit; i += p)
        {
            isPrime[i] = false;
        }
    }
}

for (int n = 100000; n < 1000000; n++)
{
    if (!isPrime[n]) continue;

    char[] originalNumber = n.ToString().ToCharArray(); 
    List<int> zeropos = new List<int>(); 
    List<int> onepos = new List<int>(); 
    List<int> twopos = new List<int>(); 
    
    for (int i = 0; i < originalNumber.Length - 1; i++)
    {
        if (originalNumber[i] == '0') zeropos.Add(i);
        else if (originalNumber[i] == '1') onepos.Add(i);
        else if (originalNumber[i] == '2') twopos.Add(i);
    }

    List<List<int>> targets = new List<List<int>>();
    if (zeropos.Count == 3) targets.Add(zeropos);
    if (onepos.Count == 3) targets.Add(onepos);
    if (twopos.Count == 3) targets.Add(twopos);

    foreach (var posList in targets)
    {
        int primecount = 0;
        for (int digit = 0; digit < 10; digit++)
        {
            if (digit == 0 && posList.Contains(0)) continue;

            char[] temp = (char[])originalNumber.Clone();
            for (int b = 0; b < posList.Count; b++)
            {
                temp[posList[b]] = (char)('0' + digit);
            }
            if (isPrime[int.Parse(new string(temp))])
            {
                primecount++;
            }
        }
        if (primecount == 8)
        {
            Console.WriteLine(n);
            return;
        }
    }
}