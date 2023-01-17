

using Answer;

PlusMinus plusMinus = new PlusMinus();

List<int> vsd = new List<int>()
{

    1, 2, 3, 4, 5, 6, 7,0,0,-2,-1,-3,-5


};
List<decimal> vs = plusMinus.Calculator(vsd);
Console.WriteLine(vs[0]);
Console.WriteLine(vs[1]);
Console.WriteLine(vs[2]);
Console.ReadLine();