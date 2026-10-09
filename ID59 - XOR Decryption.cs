string input = File.ReadAllText("0059_cipher.txt");
int[] cipher = input.Split(',').Select(int.Parse).ToArray();

for (char c1 = 'a'; c1 <= 'z'; c1++)
{
    for (char c2 = 'a'; c2 <= 'z'; c2++)
    {
        for (char c3 = 'a'; c3 <= 'z'; c3++)
        {
            char[] key = [c1, c2, c3];
            char[] decrypted = new char[cipher.Length];

            for (int i = 0; i < cipher.Length; i++)
            {
                decrypted[i] = (char)(cipher[i] ^ key[i % 3]);
            }

            string text = new string(decrypted);

            if (text.Contains(" the ") && text.Contains(" and "))
            {
                long sum = 0;
         
                for (int n = 0; n < text.Length;n++)
                {
                    sum += text[n];
                }
                Console.Write(sum);
            }
        }
    }
}