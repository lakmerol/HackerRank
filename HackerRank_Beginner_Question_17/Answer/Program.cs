
static int getMoneySpent(int[] keyboards, int[] drives, int b)
{
    int maxValue = 0;

    for (int i = 0; i < keyboards.Count(); i++)
    {
        for (int j = 0; j < drives.Count(); j++)
        {
            int value = keyboards[i] + drives[j];
            if ((value <= b) && (value > maxValue))
            {
                maxValue = value;
            }
        }
    }

    return maxValue == 0 ? -1 : maxValue;

}

int[] a = { 3, 1 };
int[] b = { 5, 2, 8 };
getMoneySpent(a, b, 3);
