static List<int> breakingRecords(List<int> scores)
{
    List<int> result = new List<int>();
    int countmin = 0;
    int countmax = 0;
    foreach (var record in scores)
    {
        if (result.Count<2)
        {
            result.Add(record);
        }
       
            bool ismin = record < result.Min();
            bool ismax = record > result.Max();
            if (ismin)
            {
                countmin++;
                result.Add(record);
                continue;
            }
            if (ismax)
            {
                countmax++;
                result.Add(record);
                continue;
            }
           
        
        result.Add(record);
    }

    result.Clear();
    result.Add(countmax);
    result.Add(countmin);
    return result;
}


List<int> b = new List<int>(){
   10, 5, 20, 20, 4, 5, 2 ,25 ,1

    };


List<int> c =breakingRecords(b);
Console.WriteLine(c[0]);
Console.WriteLine(c[1]);
Console.ReadLine();
