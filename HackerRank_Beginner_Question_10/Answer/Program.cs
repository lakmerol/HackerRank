 static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int count = 0;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            int sum = ar[i] + ar[j];
            if ((sum % k) == 0)
            {
                count++;



            }

        }

    }
    return count;
}
    int n = 6;
int k = 3;
List<int> ar = new List<int>()
{
    1, 3, 2, 6, 1, 2

};
int counter = divisibleSumPairs(n, k, ar);
Console.WriteLine(counter);
Console.ReadLine();