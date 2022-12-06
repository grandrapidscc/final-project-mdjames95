using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizert;

public class goblin {
    public int hp = 3;
    private int atk = 2;
    private static string name = "Goblin";
    public int x;
    public int y;

    public int bodySlam(int attack) {
        Console.WriteLine(name + " used body slam.");
        Console.WriteLine(name + " caused 2 damage.");

        Wizert myWizert = new Wizert();

        attack = atk;
        myWizert.hp = myWizert.hp - attack;

        Console.Write("Wizert hp remaining is ");
        return myWizert.hp;
    }
    
    public bool isAlive()
    {
        if(hp > 0)
        {
            return true;
        }
        return false;
    }

}