 static int pageCount(int n, int p)
{
        if (n / p < 1.5)
        {
            if ((n - p) / 2 < 1) return 0;
            return (n - p) / 2;
        }

        return p / 2;
}

int d = pageCount(6, 5);
Console.WriteLine(d);
Console.ReadLine();