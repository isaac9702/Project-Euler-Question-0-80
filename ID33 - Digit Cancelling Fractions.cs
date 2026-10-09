decimal product = 1;
for (int a = 10; a < 100; a++)
{
    for (int b = 10; b < 100; b++)
    {
        decimal fraction = (decimal)a / (decimal)b;
        if (fraction < 1 && fraction > 0)
        {
            string aStr = a.ToString();
            string bStr = b.ToString();
            if (aStr[1] == bStr[0] && bStr[1] != '0')
            {
                decimal newFraction = (decimal)(aStr[0] - '0') / (decimal)(bStr[1] - '0');
                if (newFraction == fraction)
                {
                    product *= 1 / fraction;
                }
            }
        }
    }
}
Console.Write(product);