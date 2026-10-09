int squareOfSum = 0; 
int sumOfSquares = 0;
for (int n = 1; n <=100; n++)
{
    squareOfSum += n; 
    sumOfSquares += n*n; 
} 
squareOfSum = squareOfSum * squareOfSum;
int ans = squareOfSum - sumOfSquares;
Console.Write(ans);