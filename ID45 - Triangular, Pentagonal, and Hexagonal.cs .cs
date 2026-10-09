long n = 145; 
while (true)
{

    long h = n * (2 * n - 1); 
    double p = (1.0 + Math.Sqrt(1.0 + 24.0 * h)) / 6.0;
    if (p == (long)p) 
    {
        Console.WriteLine(h);
        break;
    }

    n++;
}