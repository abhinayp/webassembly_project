using System;
using System.Collections.Generic;

public class TrapList
{

    public TrapList()
    {
    }

    public Trap[] generateTraps()
    {

        Random rnd = new Random();
        int numOfTraps = rnd.Next(15, 26);
        Trap[] trapList = new Trap[numOfTraps];

        for (int i = 0; i <= numOfTraps; i++)
        {
            int x = rnd.Next(0, 15);
            int y = rnd.Next(0, 15);
            Trap t = new Trap();
            t.x = x;
            t.y = y;
            trapList[i] = t;
            Console.WriteLine(trapList);
        }


        return trapList;
    }
}