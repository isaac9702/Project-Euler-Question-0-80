int limit = 1000000;
int result = 1;
int[] primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
foreach (int p in primes)
{
    if (result * p > limit) 
        break;
    result *= p;
}
Console.WriteLine(result); 