bool end = false;
int num = 1;

while (end == false)
{
    num ++;
    for (int n = 1; n <= 20; n++)
    {
        if (num % n != 0)
        {
            end = false;
            break;
        }
        else
        {
            end = true; 

        }
    } 
    
} 
Console.Write(num);