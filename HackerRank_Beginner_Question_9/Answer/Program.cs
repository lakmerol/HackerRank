static int birthday(List<int> s, int d, int m)
    => s.Count < m
     ? 0
     : birthday(s.Skip(1).ToList(), d, m)
       + (s.Take(m).Sum() == d ? 1 : 0);




List<int> s2 = new List<int>()
    {
        1, 2, 1, 3 ,2
    };
Random rn = new Random();
int d = rn.Next(1, 2);
int m = rn.Next(1, 3);
int result=birthday(s2, d, m);
Console.WriteLine(result);
Console.ReadLine();
