static bool isPrime(int num)
{
    if (num <= 1)
    {
        return false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
} 

int ans = 0;
int n = 11;
int count = 0; 
bool end = false; 

while (end == false)
{
    if (isPrime(n) == true)
    {
        string digits = n.ToString();
        bool prime = true;

        for (int i = 1; i < digits.Length; i++)
        {
            int forwardNum = int.Parse(digits.Substring(i));            
            int backwardNum = int.Parse(digits.Substring(0, digits.Length - i));

            if (isPrime(forwardNum) == false || isPrime(backwardNum) == false)
            {
                prime = false;
                break;
            }
        }
        if (prime == true)
        {
            count++; 
            ans += n; 
            if (count == 11)
            {
                end = true;
                Console.Write(ans);
            }
        }
    }
    n++; 
}