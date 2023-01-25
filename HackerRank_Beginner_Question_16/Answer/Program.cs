static int countingValleys(int steps, string path)
{
    char[] pathv = path.ToCharArray();
    int sealevel = 0; int counter = 0;
 while (steps > 0)
    {

       if (pathv[0] == 'D') sealevel--;
       else sealevel++;
        pathv = pathv.Skip(1).ToArray();
        steps--;
       if (sealevel == -1)
        {
            if (pathv[0] == 'D') sealevel--;
            else sealevel++;
            pathv = pathv.Skip(1).ToArray();

            steps--;
            if (sealevel == 0)
            {
                counter++;
            }

        }

    }
    return counter;
}

int i = countingValleys(8, "UDDDUDUU");
Console.WriteLine(i);
Console.ReadLine();