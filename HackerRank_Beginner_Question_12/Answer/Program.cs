 static int migratoryBirds(List<int> arr)
{
    int one = arr.Count(x => x == 1);
    int two = arr.Count(x => x == 2);
    int three = arr.Count(x => x == 3);
    int four = arr.Count(x => x == 4);
    int five = arr.Count(x => x == 5);
    List<int> counts = new List<int>()
    {
        one, two, three, four, five
    };
    bool control = counts.Count(x=>x==counts.Max())>1;
    if (control)
    {
        int divnum = counts.IndexOf(counts.Max()) + 1;
      arr =  arr.Skip(divnum).ToList();
        migratoryBirds(arr);
    }
  int num = counts.IndexOf(counts.Max()) + 1;

    return num;

}

List<int> ts = new List<int>()
{
    1, 2 ,3 ,4 ,5, 4 ,3 ,2 ,1, 3, 4
};
int result = migratoryBirds(ts);
Console.WriteLine(result);
Console.ReadLine();
