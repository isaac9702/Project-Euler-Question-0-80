int[] units = { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4 };
int[] teens = { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
int[] tens = { 0, 0, 6, 6, 5, 5, 5, 7, 6, 6 };
int hundred = 7;  
int and = 3;  
int totalLetters = 0;

for (int i = 1; i <= 1000; i++)
{
    if (i == 1000)
    {
        totalLetters += 11;
    }
    else
    {
        int hundredth = i / 100;
        int remainder = i % 100;
        if (hundredth > 0)
        {
            totalLetters += units[hundredth] + hundred;
            if (remainder > 0)
            {
                totalLetters += and;
            }
        }
        if (remainder > 0)
        {
            if (remainder < 10)
            {
                totalLetters += units[remainder];
            }
            else if (remainder < 20)
            {
                totalLetters += teens[remainder - 10];
            }
            else
            {
                totalLetters += tens[remainder / 10] + units[remainder % 10];
            }
        }
    }
}
Console.WriteLine(totalLetters); 
    
