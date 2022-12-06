using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizert;

public class orc {
    public  int hp = 5;
    private int atk = 3;
    private string name = "Orc";
    public int x;
    public int y;

    public int cleave(int attack) {
        Console.WriteLine(name + " used cleave.");
        Console.WriteLine(name + " caused 3 damage.");

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