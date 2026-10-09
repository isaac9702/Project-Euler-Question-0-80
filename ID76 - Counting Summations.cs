int target = 100;
long[] ways = new long[target + 1];
ways[0] = 1;
for (int coin = 1; coin < target; coin++)
{
    for (int i = coin; i <= target; i++)
    {
        ways[i] += ways[i - coin];
    }
}
Console.Write(ways[target]);