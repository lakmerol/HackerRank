


using System.Collections;

ArrayList MinMax(List<int> list)
{
    list.Sort();
    Int64 min = Convert.ToInt64(list[0] + list[1] + list[2] + list[3]);
    Int64 max = Convert.ToInt64(list[1] + list[2] + list[3] + list[4]);
    ArrayList arrayList = new ArrayList();
    arrayList.Add(min);
    arrayList.Add(max);
    return arrayList;
}

List<int> vs = new List<int>()
{

256741038, 623958417, 467905213, 714532089, 938071625

};
MinMax(vs);
Console.WriteLine(MinMax(vs)[0]);
Console.WriteLine(MinMax(vs)[1]);
Console.ReadLine();