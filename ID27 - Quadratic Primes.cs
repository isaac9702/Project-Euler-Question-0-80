using System;
using System.Collections.Generic;

List<int> primes = new List<int>(); 
for (int z = 2; z <= 1000; z++)
{
    bool prime = true;
    for (int y = 2; y * y <= z; y++)
    {
        if (z % y == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime == true)
    { 
        primes.Add(z);
    }
}

int ans = 0;
int maxN = 0;
foreach (int b in primes)
{
    for (int a = -999; a < 1000; a++)
    {
        int n = 0;
        bool end = false;
        while (end == false)
        {
            int result = n * n + a * n + b;
            
            if (result < 2) 
            { 
                end = true;
                break;
            }
            bool prime = true;
            for (int j = 2; j * j <= result; j++)
            {
                if (result % j == 0)
                {
                    prime = false;
                    end = true;
                    break;
                }
            }
            if (prime == false)
            { 
                end = true;
                break;
            }
            n++;
        }
        if (n > maxN)
        {
            maxN = n;
            ans = a * b;
        }
    }
}
Console.WriteLine(ans);