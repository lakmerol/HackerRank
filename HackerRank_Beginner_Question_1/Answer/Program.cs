<<<<<<< HEAD:Answer/Program.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Beginner_Question_1
=======
>>>>>>> 2237cad411dbc8e0cd11550cbe1b64791daee5af:Answer/TEXT.md
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Helper.timeConversion("12:54:33AM");
        }
    }

    internal class Helper
    {
        public static string timeConversion(string s)
        {

            string ls = s.Substring(s.Length - 2, 2);
            if (ls == "AM")
            {

                s = s.Substring(0, s.Length - 2);
                if (s.StartsWith("12"))
                {
                    s = s.Substring(2, s.Length - 2);
                    s = s.Insert(0, "00");
                    return s;

                }
                return s;

            }
            else
            {
                s = s.Substring(0, s.Length - 2);
                int Hours = Convert.ToInt32(s.Substring(0, 2));
                if (Hours == 12)
                {
                    return s;
                }


                int TwentyFourClock = Hours + 12;
                s = s.Substring(2, s.Length - 2);
                s = s.Insert(0, TwentyFourClock.ToString());
                return s;

            }


        }
<<<<<<< HEAD:Answer/Program.cs

    }
}
=======
>>>>>>> 2237cad411dbc8e0cd11550cbe1b64791daee5af:Answer/TEXT.md
