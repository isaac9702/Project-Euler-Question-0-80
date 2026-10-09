long number = 0; 
for (long n = 1; n <= 100000000; n++)
{
    number += n; 
    int factors = 0;
    for (long i = 1; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        { 
            if (i*i == number)
            {
            factors ++; 
            } 
            else
            { 
                factors += 2;
            }
        }
    }
    if (factors > 500) 
    { 
        Console.Write(number);
        break;
    }
    
} 
