using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizert;

public class Wizert 
{
    public int hp = 100;
    public int mp = 200;
    public int y = 1;
    public int x = 1;

    public bool isAlive()
    {
        if(hp > 0)
        {
            return true;
        }
        return false;
    }

    public void Heal()
    {
        
        if(mp <= 4)
        {
            Console.WriteLine("You don't have enough power to heal yourself.");
        }
        if(mp >= 5)
        {
            if(hp == 100)
            {
                Console.WriteLine("Health is already full.");
            }
            if(hp >= 97)
            {
                Console.WriteLine("A golden light shines down upon you. HP fully restored.");
                hp = 100;
                mp = mp - 5;
            }
            else
            {
                hp = hp + 3;
                mp = mp - 5;
            }
        }
    }

    public void fireball()
    {
        if(mp < 3)
        {
            Console.WriteLine("Seems like you don't have enough energy for this.");
        }
        else
        {
            Console.WriteLine("You launch a blazing ball of energy at your opponent causing 5 damage.");
            mp = mp - 3;
        }
    }


    public void flee()
    {
        Random randomFlee = new Random();

        int fleeChance;
        fleeChance = randomFlee.Next(1, 5);

        if(fleeChance == 3)
        {
            Console.WriteLine("It appears you can't outrun this enemy");
        }
        else
        {
            if(y < 5 && y > 1)
            {
                Console.WriteLine("You fled south!");
                y = y - 1;
            }
            else if(y == 1)
            {
                Console.WriteLine("You fled to the North!");
                y = y + 1;
            }
            else if(y == 5)
            {
                Console.WriteLine("You fled to South!");
                y = y - 1;
            }
             if(x < 5 && x > 1)
            {
                Console.WriteLine("You fled East");
                x = x + 1;
            }
            else if(x == 1)
            {
                Console.WriteLine("You fled to the East!");
                x = x + 1;
            }
            else if(x == 5)
            {
                Console.WriteLine("You fled to the West!");
                x = x - 1;
            }
        }
    }

    public void move()
    {
        Console.WriteLine("Which direction would you like to go?");
        Console.WriteLine("Enter 1 for north, 2 for south, 3 for east, 4 for west.");
        String direction = Console.ReadLine();
        
        int move;
        while(!int.TryParse(direction, out move) && move > 4 && move < 0)
        {
            Console.WriteLine("Input is invalid. Please enter 1 for north, 2 for south, 3 for east, 4 for west.");
            direction = Console.ReadLine();
        }

        if(move == 1)
        {
            Console.WriteLine("You chose to travel North.");
            if(y == 5)
            {
                Console.WriteLine("Looks like there's a huge wall in the way. Doesn't look like you'll be able to move past it.");
                Console.WriteLine();
            }
            else
            {
                y = y + 1;
            }
        }
        if(move == 2)
        {
            Console.WriteLine("You chose to travel South.");
            if(y == 1)
            {
                Console.WriteLine("Looks like there's a huge wall in the way. Doesn't look like you'll be able to move past it.");
                Console.WriteLine();
            }
            else
            {
                y = y - 1;
            }
        }
        if(move == 3)
        {
            Console.WriteLine("You chose to travel East.");
            if(x == 5)
            {
                Console.WriteLine("Looks like there's a huge wall in the way. Doesn't look like you'll be able to move past it.");
                Console.WriteLine();
            }
            else
            {
                x = x + 1;
            }
        }
        if(move == 4)
        {
            Console.WriteLine("You chose to travel West.");
            if(x == 1)
            {
                Console.WriteLine("Looks like there's a huge wall in the way. Doesn't look like you'll be able to move past it.");
                Console.WriteLine();
            }
            else
            {
                x = x - 1;
            }
        }
        

    }
}