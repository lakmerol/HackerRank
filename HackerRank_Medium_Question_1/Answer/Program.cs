using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Medium_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc = "abc";
            string bca = "bca";
            string.Compare(bca, abc);
            BiggerTaker("abcdefg");

        }
        static string BiggerTaker(string s)
        {

            string f = "a";
            string d = "b";

            while (string.Compare(d, f) == 1)
            {
                int c = 1;
                f = s.Substring(s.Length - c, 1);
                d = s.Substring(s.Length - (c + 1), 1);
                if (d == f)  return s = "No Answer";
                
                c++;

            }
            int x = s.IndexOf(f);
            int y = s.IndexOf(d);
            s = s.Remove(y, 1);
            s = s.Insert(y, f);
            s = s.Remove(x, 1);
            s = s.Insert(x, d);
            return s;
        }
    }
}



