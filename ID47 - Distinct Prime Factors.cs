bool found = false; 
int n = 20;
int conCount = 0;
int first = 0;
while (found == false)
{
    int num = n;
    int factorscount = 0;
    for (int i = 2;i < n; i++)
    {
        if (num%i == 0)
        {
            factorscount ++;
        }
        while (num%i == 0)
        {
            num = num / i; 
        }
    }
    if (factorscount == 4)
    {
        conCount++;
        if (conCount == 4)
        {
            Console.Write(first);
            found = true;
        }
        else if (conCount == 1)
        {
            first = n;
        }
    }
    else
    {
        conCount = 0;
    }
    n++;
}