


using System.Collections;

ArrayList MinMax(List<Int64> list)
{
    list.Sort();
    Int64 min = Convert.ToInt64(list[0] + list[1] + list[2] + list[3]);
    Int64 max = Convert.ToInt64(list[1] + list[2] + list[3] + list[4]);
    ArrayList arrayList = new ArrayList();
    arrayList.Add(min);
    arrayList.Add(max);
    return arrayList;
}

List<Int64> vs = new List<Int64>()
{

140638725, 436257910, 953274816, 734065819, 362748590

};
MinMax(vs);
Console.WriteLine(MinMax(vs)[0]);
Console.WriteLine(MinMax(vs)[0]);
Console.ReadLine();