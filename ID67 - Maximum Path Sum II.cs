using System.IO;

string fileContent = File.ReadAllText("0067_triangle.txt");
int[][] triangle = fileContent
    .Trim()
    .Split('\n')
    .Select(row => row.Trim().Split(' ').Select(int.Parse).ToArray())
    .ToArray();
for (int row = triangle.Length - 2; row >= 0; row--)
{
    for (int col = 0; col < triangle[row].Length; col++)
    {
        triangle[row][col] += Math.Max(triangle[row + 1][col], triangle[row + 1][col + 1]);
    }
}
Console.WriteLine(triangle[0][0]);