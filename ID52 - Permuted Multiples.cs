bool found = false;
int n = 1;
while (found == false)
{
    char[] digits = n.ToString().ToCharArray();
    char[] twice = (n*2).ToString().ToCharArray();
    char[] third = (n*3).ToString().ToCharArray(); 
    char[] fourth = (n*4).ToString().ToCharArray(); 
    char[] fifth = (n*5).ToString().ToCharArray(); 
    char[] sixth = (n*6).ToString().ToCharArray();
    Array.Sort(digits);
    Array.Sort(twice);
    Array.Sort(third);
    Array.Sort(fourth);
    Array.Sort(fifth);
    Array.Sort(sixth);

    if (digits.SequenceEqual(twice) &&
        digits.SequenceEqual(third) &&
        digits.SequenceEqual(fourth) &&
        digits.SequenceEqual(fifth) &&
        digits.SequenceEqual(sixth))
    {
        found = true;
        Console.Write(n);
    }
    n++;
}