using System.Numerics;
List<BigInteger> results = new List<BigInteger>();
BigInteger result;
for (BigInteger a = 2; a <= 100; a++)
{
    for (BigInteger b = 2; b<= 100; b++)
    {
        result = (BigInteger)Math.Pow(a,b); 
        if (results.Contains(result) == false)
        { 
            results.Add(result); 
        }
    }
} 
Console.Write(results.Count);