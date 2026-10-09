string[] keylog = {
    "319", "680", "180", "690", "129", "620", "762", "689", "762", "318",
    "368", "710", "720", "710", "629", "168", "160", "689", "716", "731",
    "736", "729", "316", "729", "729", "710", "769", "290", "719", "680",
    "318", "389", "162", "289", "162", "718", "729", "319", "790", "680",
    "890", "362", "319", "760", "316", "729", "380", "319", "728", "716"
};
HashSet<char> digits = new HashSet<char>();
Dictionary<char, HashSet<char>> follows = new Dictionary<char, HashSet<char>>();

foreach (string attempt in keylog)
{
    char first = attempt[0];
    char second = attempt[1];
    char third = attempt[2];
    digits.Add(first);
    digits.Add(second);
    digits.Add(third);
    if (!follows.ContainsKey(first)) 
    {
        follows[first] = new HashSet<char>();
    }
    if (!follows.ContainsKey(second)) 
    {
        follows[second] = new HashSet<char>();
    }
    if (!follows.ContainsKey(third)) 
    { 
        follows[third] = new HashSet<char>();
    }
    follows[first].Add(second);
    follows[first].Add(third);
    follows[second].Add(third);
}
List<char> passcode = digits.ToList();
passcode.Sort((a, b) => follows[b].Count.CompareTo(follows[a].Count));
Console.WriteLine(new string(passcode.ToArray()));