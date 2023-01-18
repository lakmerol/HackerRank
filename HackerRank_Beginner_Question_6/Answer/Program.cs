static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        if (grades[i] < 38) continue;
        if (grades[i] > 95)
        {
            if (grades[i] == 96 || grades[i] == 97 || grades[i] == 100) continue;
            int tohundred = 100 - grades[i];
            grades[i] += tohundred;
            continue;
        }
        if (grades[i] % 5 >= 3)
        {
            int range = grades[i] % 5;
            int addnum = 5 - range;
            grades[i] += addnum;
            continue;
        }
        continue;

    }


    return grades;
}


