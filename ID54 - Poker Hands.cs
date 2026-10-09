string[] lines = File.ReadAllLines("0054_poker.txt");
int player1Wins = 0;

foreach (string line in lines)
{
    if (string.IsNullOrWhiteSpace(line)) continue;

    string[] cards = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[,] hand1 = ParseHand(cards.Take(5).ToArray());
    int[,] hand2 = ParseHand(cards.Skip(5).Take(5).ToArray());

    if (CompareHands(EvaluateHand(hand1), EvaluateHand(hand2)) > 0)
    {
        player1Wins++;
    }
}

Console.WriteLine(player1Wins); 
static int[,] ParseHand(string[] cardStrings)
{
int[,] hand = new int[5, 2];
for (int i = 0; i < 5; i++)
{
    hand[i, 0] = cardStrings[i][0] switch
    {
        '2' => 2, '3' => 3, '4' => 4, '5' => 5, '6' => 6,
        '7' => 7, '8' => 8, '9' => 9, 'T' => 10,
        'J' => 11, 'Q' => 12, 'K' => 13, 'A' => 14,
        _ => 0
    };

    hand[i, 1] = cardStrings[i][1] switch
    {
        'C' => 0, 'D' => 1, 'H' => 2, 'S' => 3, _ => 0
    };
}
return hand;
}
static int[] EvaluateHand(int[,] hand)
{
int[] values = new int[5];
int[] suits = new int[5];

for (int i = 0; i < 5; i++)
{
    values[i] = hand[i, 0];
    suits[i] = hand[i, 1];
}
Array.Sort(values);
Array.Reverse(values);
bool isFlush = suits.All(s => s == suits[0]);
bool isStandardStraight = values.Distinct().Count() == 5 && (values[0] - values[4] == 4);
bool isAceLowStraight = values.SequenceEqual(new[] { 14, 5, 4, 3, 2 });
bool isStraight = isStandardStraight || isAceLowStraight;
if (isAceLowStraight)
{
    values = new[] { 5, 4, 3, 2, 1 }; 
}
int[] orderedValues = values.GroupBy(v => v)
                            .OrderByDescending(g => g.Count())
                            .ThenByDescending(g => g.Key)
                            .SelectMany(g => g)
                            .ToArray();

var groups = values.GroupBy(v => v)
                    .Select(g => new { Value = g.Key, Count = g.Count() })
                    .OrderByDescending(g => g.Count)
                    .ThenByDescending(g => g.Value)
                    .ToList();

if (isStraight && isFlush) return CombineScore(8, values);
if (groups[0].Count == 4) return CombineScore(7, orderedValues);
if (groups[0].Count == 3 && groups[1].Count == 2) return CombineScore(6, orderedValues);
if (isFlush) return CombineScore(5, values);
if (isStraight) return CombineScore(4, values);
if (groups[0].Count == 3) return CombineScore(3, orderedValues);
if (groups[0].Count == 2 && groups[1].Count == 2) return CombineScore(2, orderedValues);
if (groups[0].Count == 2) return CombineScore(1, orderedValues);

return CombineScore(0, values);
}
static int[] CombineScore(int rank, int[] tieBreakers)
{
int[] score = new int[1 + tieBreakers.Length];
score[0] = rank;
Array.Copy(tieBreakers, 0, score, 1, tieBreakers.Length);
return score;
}
static int CompareHands(int[] score1, int[] score2)
{
for (int i = 0; i < Math.Min(score1.Length, score2.Length); i++)
{
    if (score1[i] != score2[i])
        return score1[i].CompareTo(score2[i]);
}
return 0;
}
