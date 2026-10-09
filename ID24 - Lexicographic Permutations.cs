using System.Collections.Generic;
using System.Linq;
List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] number = Array.Empty<string>();
int remainder = 999999;
for (int n = nums.Count-1; n>= 0 ;n--)
{
    int product = 1;
    for (int i = 1; i<= n;i++)
    {
        product *= i; 
    }
    int index = remainder / product; 
    remainder = remainder % product;

    number = number.Append(nums[index].ToString()).ToArray();
    nums.Remove(nums[index]);
}
string numbers = ""; 
for (int a = 0; a<number.Length;a++)
{
    numbers += number[a];
}
long ans = long.Parse(numbers);
Console.Write(ans);


