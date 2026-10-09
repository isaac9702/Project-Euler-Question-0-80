int ans = 0; 
for (int n = 1; n < 1000000; n++)
{
    string number = n.ToString(); 
    string reversed = new string(number.Reverse().ToArray());
    if (number == reversed)
    {
        string binary = Convert.ToString(n,2); 
        string reversedBinary = new string(binary.Reverse().ToArray()); 
        if (binary == reversedBinary)
        {
            ans += n;
        }
    }
}
Console.Write(ans);
