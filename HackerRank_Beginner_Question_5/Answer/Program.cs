

static int birthDayCakeCandles(List<int> candles)
{
    int max = candles.Max();
    int heightest =  candles.Count(x => x == max);
    return heightest;
}
