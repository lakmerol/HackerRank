static string timeConversion(string s)
{
    string ls = s.Substring(s.Length - 2, 2);
    if (ls == "AM")
    {

        s = s.Substring(0, s.Length - 2);
        if (s.StartsWith("1"))
        {
            if (s.StartsWith("12"))
            {
                s = s.Substring(2, s.Length - 2);
                s = s.Insert(0, "00");
                return s;
            }
            s = s.Substring(2, s.Length - 2);
            s = s.Insert(0, "12");
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
            s = s.Substring(2, s.Length - 2);
            s = s.Insert(0, Hours.ToString());
            return s;
        }
        int TwentyFourClock = Hours + 12;
        s = s.Substring(2, s.Length - 2);
        s = s.Insert(0, TwentyFourClock.ToString());
        return s;

    }


}

string s =timeConversion("12:40:22AM");
Console.WriteLine(s);
Console.ReadLine();