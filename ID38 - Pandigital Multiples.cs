static bool IsPandigital(string s)
{
    if (s.Length != 9 || s.Contains('0')) return false;
    return s.Distinct().Count() == 9;
}
int maxPandigital = 0;
for (int x = 9876; x >= 9123; x--)
{
    string concatenated = $"{x}{x * 2}";

    if (IsPandigital(concatenated))
    {
        maxPandigital = int.Parse(concatenated);
        break; 
    }
}
Console.WriteLine(maxPandigital);
