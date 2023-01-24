static string bonAppetit(List<int> bill, int k, int b)
{
    bill.RemoveAt(k);
    int Account = bill.Sum() / 2;
    if (Account == b) return "Bon Appetit";
    return (b - Account).ToString();
}

