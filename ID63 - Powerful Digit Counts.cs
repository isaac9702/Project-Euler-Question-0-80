int count = 0;
for (int x = 1; x <= 9; x++)
{
    int power = 1;
    while (true)
    {
        double digits = Math.Floor(power * Math.Log10(x)) + 1;
        if (digits == power)
        {
            count++;
        }
        else
        {
            break;
        }

        power++;
    }
}
Console.WriteLine(count);