int fiba = 1; 
int ans = 0;
int second = 1;

while (fiba < 4000000)
{
    int first = second;
    second = fiba;
    fiba = first + second; 
    
    if (fiba % 2 == 0)
    {
        ans += fiba;
    }
}

Console.Write(ans);