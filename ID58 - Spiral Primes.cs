int sidelength = 7; 
bool end = false; 
List<long> numbers = [1,3,5,7,9,13,17,21,25,31,37,43,49];
int counter = 8;

while (end == false)
{
    sidelength +=2;
    long bottomright = sidelength * sidelength;
    long bottomleft = bottomright - (sidelength - 1);
    long topleft = bottomleft - (sidelength - 1); 
    long topright = topleft - (sidelength - 1); 

    numbers.Add(bottomleft); 
    numbers.Add(bottomright); 
    numbers.Add(topleft);
    numbers.Add(topright); 

    if (isPrime(bottomright) == true)
    {
        counter++;
    }
    if (isPrime(bottomleft) == true)
    {
        counter++;
    }
    if (isPrime(topleft) == true)
    {
        counter++; 
    }
    if (isPrime(topright) == true)
    {
        counter++;
    }

    decimal rate = (decimal)counter / numbers.Count;
    if (rate < 0.1m)
    {
        end = true;
        Console.WriteLine(sidelength);
    }
}

static bool isPrime(long num)
{
    long number = num;
    if (number < 2)
    {
        return false;
    }
    else
    {
        for (long n = 2; n <= (long)Math.Floor(Math.Sqrt(number)); n++)
        {
            if (number % n == 0)
            {
                return false;
            }
        }
        return true;
    }
}