HashSet<int> products = new HashSet<int>();
for (int a = 1; a <= 99; a++)
{
    for (int b = 1; b <= 9876; b++)
    {
        int product = a * b; 
        string combined = $"{a}{b}{product}";
        if (combined.Length != 9) 
        {
            continue;
        }
        char[] digits = combined.ToCharArray();
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        bool pandigital = true;

        for (int n = 0; n < digits.Length; n++)
        {
            int val = digits[n] - '0'; 
            if (numbers.Contains(val))
            {
                numbers.Remove(val);
            }
            else
            {
                pandigital = false; 
                break; 
            }
        }

        if (pandigital)
        {
            products.Add(product); 
        }
    }
}
int sum = products.Sum();
Console.Write(sum);