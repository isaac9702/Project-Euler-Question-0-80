List<int> factorialsList = factorials();
int anscount = 0;

for (int n = 1; n < 1_000_000; n++)
{
    int number = n;
    List<int> chain = new List<int>();
    while (chain.Contains(number)== false)
    {
        chain.Add(number);
        int sum = 0;
        int temp = number;
        while (temp > 0)
        {
            sum += factorialsList[temp % 10];
            temp /= 10;
        }
        number = sum;
    }
    if (chain.Count == 60)
    {
        anscount++;
    }
}
Console.WriteLine(anscount);

static List<int> factorials()
{
    List<int> result = [1];
    for (int i = 1; i < 10; i++)
    {
        result.Add(i * result[i - 1]);
    }
    return result;
}