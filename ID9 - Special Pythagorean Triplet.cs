int num1 = 0; 
int num2 = 0; 
double num3 = 0;
bool end1 = false;
bool end3 = false;
while (end1 == false)
{
    num1++;
    num2 = 0;
    bool end2 = false;
    while (end2 == false)
    {
        
        num2++;
   
        
        num3 = Math.Sqrt(num1*num1 + num2*num2);
        if (num3 % 1 == 0)
        {

            if (num1 + num2 + num3 == 1000)
            {
                end1 = true; 
                end2 = true;
            } 
        }
        if (num2>1000)
        { 
            end2 = true;
        }
    }
}
long ans = (long)num1*(long)num2*(long)num3; 
Console.Write(ans);