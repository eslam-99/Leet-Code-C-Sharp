public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        if (fruits.Length < 3) return fruits.Length;
        int t1 = -1, t2 = -1;
        int c1 = 0, c2 = 0;
        int max = 0, contSeqStartIndex = 0;
        for (int i = 0; i < fruits.Length ; i++)
        {
            if (t1 == -1)
            {
                t1 = fruits[i];
                c1 = 1;
            }
            else if (t2 == -1 && fruits[i] != t1)
            {
                t2 = fruits[i];
                c2 = 1;
            }
            else
            {
                if (t1 == fruits[i]) c1++;
                else if (t2 == fruits[i]) c2++;
                else
                {
                    if (c1 + c2 > max) max = c1 + c2;
                    if (fruits[contSeqStartIndex] == t1)
                    {
                        c1 = i - contSeqStartIndex + 1;
                        t2 = fruits[i];
                        c2 = 1;
                    }
                    else if (fruits[contSeqStartIndex] == t2)
                    {
                        c2 = i - contSeqStartIndex + 1;
                        t1 = fruits[i];
                        c1 = 1;
                    }
                }
            }
            if (i > 0 && fruits[i] != fruits[i - 1]) contSeqStartIndex = i;
        }
        if (c1 + c2 > max) max = c1 + c2;
        return max;
    }
}