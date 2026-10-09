long num = 1L; 
bool end = false; 
int counter = 0;
while (end == false)
{
    num++;
    bool prime = true;
    for (long n = 2L; n<num;n++)
    {
        if (num%n == 0)
        {
            prime = false;
            break;
        }
    }

    if (prime == true)
    {
        counter++; 
    
        if (counter == 10001)
        {
            end = true;
        }
    }
}
Console.Write(num);