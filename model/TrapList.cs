using System;
using System.Collections.Generic;

public class TrapList
{

    public TrapList()
    {
    }

    public static IList<Trap> generateTraps()
    {

        Random rnd = new Random();
        int numOfTraps = rnd.Next(Values.rand_min, Values.rand_max);
        IList<Trap> trapList = new List<Trap>();

        for (int i = 0; i <= numOfTraps; i++)
        {
            int x = rnd.Next(0, Values.x);
            int y = rnd.Next(0, Values.y);
            Trap t = new Trap();
            t.x = x;
            t.y = y;
            trapList.Add(t);
        }


        return trapList;
    }
}

public class Values {
    public static int x = 8;
    public static int y = 8;

    public static int rand_min = 1;
    public static int rand_max = 3;
}
