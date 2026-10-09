using System.Numerics;
BigInteger fibanacci = 1; 
BigInteger index = 2; 
BigInteger first = 1; 
BigInteger second = 1; 
bool end = false; 
while (end == false)
{
    fibanacci = first + second; 
    first = second;
    second = fibanacci; 
    index ++;
    string number = fibanacci.ToString();
    if (number.Length == 1000)
    {
        end = true; 
        Console.Write(index);
    }
} 
