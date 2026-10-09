long[,] grid = new long[21,21]; 
for (int a = 0; a <21; a++)
{
    grid[a,0] = 1; 
    grid[0,a] = 1;
} 
for (int n = 1; n<21; n++)
{
    for (int i = 1; i <21; i++)
    {
        grid[n,i] = grid[n-1,i] + grid[n,i-1];
    }
} 
Console.Write(grid[20,20]); 
