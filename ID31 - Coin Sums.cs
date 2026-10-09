int[] coins = [1,2,5,10,20,50,100,200];
int target = 200; 
int[] ways = new int[target+1]; 
ways[0] = 1; 
for (int i= 0; i < coins.Length;i++)
{
    for (int n = coins[i]; n<= target; n++)
    {
        ways[n] += ways[n - coins[i]]; 
    }
}
Console.Write(ways[target]); 
