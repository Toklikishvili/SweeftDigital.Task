namespace SweeftDigitalTask.Algorithm
{
    public static class AlgorithmSolution
    {
        public static bool IsPalindrome(this string text)
        {
            if (text == null) return false;
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                if (char.ToLower(text[i]) != char.ToLower(text[j]))
                    return false;
            }
            return true;
        }

        public static int MinSplit(this int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int numCoins = 0;

            foreach (int coin in coins)
            {
                int coinCount = amount / coin;
                numCoins += coinCount;
                amount -= coin * coinCount;
                if (amount == 0)
                    break;
            }
            return numCoins;
        }

        public static int NotContains(this int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] <= 0)
                {
                    array[i] = n + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                int value = Math.Abs(array[i]);

                if (value <= n && array[value - 1] > 0)
                {
                    array[value - 1] = -array[value - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    return i + 1;
                }
            }
            return n + 1;
        }

        public static bool IsProperly(this string sequence)
        {
            int count = 0;
            foreach (char c in sequence)
            {
                if (c == '(')
                    count++;
                else if (c == ')')
                {
                    count--;
                    if (count < 0)
                        return false;
                }
            }
            return count == 0;
        }

        public static int CountVariants(this int stairCount)
        {
            if (stairCount <= 1)
                return 1;

            int[] variants = new int[stairCount + 1];
            variants[0] = 1;
            variants[1] = 1;

            for (int i = 2; i <= stairCount; i++)
                variants[i] = variants[i - 1] + variants[i - 2];

            return variants[stairCount];
        }
    }
}