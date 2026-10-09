static bool IsPrime(int num)
{
    if (num <= 1) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false; // Quick check for even numbers

    int boundary = (int)Math.Sqrt(num);
    for (int i = 3; i <= boundary; i += 2) // Step by 2 to skip even numbers
    {
        if (num % i == 0) return false;
    }
    return true;
}

int count = 0;
for (int n = 1; n < 1000000; n++)
{
    if (IsPrime(n) == true)
    {
        if (n > 9)
        {
            string s = n.ToString();
            if (s.Contains('0') || s.Contains('2') || s.Contains('4') || 
                s.Contains('5') || s.Contains('6') || s.Contains('8'))
            {
                continue;
            }
        }

        bool circularPrime = true;
        string strNum = n.ToString();
        int length = strNum.Length;
        for (int i = 0; i < length; i++)
        {
            strNum = strNum.Substring(1) + strNum[0];
            int rotatedNum = int.Parse(strNum);

            if (IsPrime(rotatedNum) == false)
            {
                circularPrime = false;
                break;
            }
        }
        if (circularPrime == true)
        {
            count++;
        }
    }
}
Console.Write(count);

