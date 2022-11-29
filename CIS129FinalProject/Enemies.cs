using System;
using wizert;

namespace enemies;

public static class goblin {
    public static int hp = 3;
    private static int atk = 2;
    private static string name = "Goblin";

    public static int bodySlam(int attack) {
        Console.WriteLine(name + " used body slam.");
        Console.WriteLine(name + " caused 2 damage.");

        attack = atk;
        Wizert.hp = Wizert.hp - attack;

        Console.Write("Wizert hp remaining is ");

        return Wizert.hp;
    }

}

public static class orc {
    public static int hp = 5;
    private static int atk = 3;
    private static string name = "Orc";

    public static int cleave(int attack) {
        Console.WriteLine(name + " used cleave.");
        Console.WriteLine(name + " caused 3 damage.");

        attack = atk;
        Wizert.hp = Wizert.hp - attack;

        Console.Write("Wizert hp remaining is ");

        return Wizert.hp;
    }

}

public static class banshee {
    public static int hp = 8;
    private static int atk = 5;
    private static string name = "Banshee";

    public static int screech(int attack) {
        Console.WriteLine(name + " used screech.");
        Console.WriteLine(name + " caused 5 damage.");

        attack = atk;
        Wizert.hp = Wizert.hp - attack;

        Console.Write("Wizert hp remaining is ");

        return Wizert.hp;
    }

}