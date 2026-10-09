using System;
using System.Linq;
int number = 0;

bool pali = false;
int failcounter = 0;
int palindrome = 0;
for (int first = 999; first > 99; first --)

{
    for (int second = 999; second > 99; second --)
    {
    
        number = first*second;
        if (palindrome > number)
        {
            break;
        }
        string num = number.ToString(); 
        char[] numArray = num.ToCharArray();
        int counter = 0;
        pali = true;
        for (int n = numArray.Length-1; n >=0 ;n--)
        {
            if (numArray[counter] != numArray[n])
            {
                pali = false;
                break;
            }
            counter++; 
        }
        
        if (pali == true)
        {
            palindrome = number;
        
        }
 
    }
    
}

Console.Write(palindrome);


