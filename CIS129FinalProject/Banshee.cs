using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizert;

public class banshee {
    public int hp = 8;
    private int atk = 5;
    private string name = "Banshee";
    public int x;
    public int y;

    public int screech(int attack) {
        Console.WriteLine(name + " used screech.");
        Console.WriteLine(name + " caused 5 damage.");

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