using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizert;

class Program {
   
   static void Main(string[] args)
   {
        Wizert myWizert = new Wizert();
        Random rnd = new Random();
        myWizert.x = rnd.Next(1, 6);
        myWizert.y = rnd.Next(1, 6);

        int DungeonX = rnd.Next(1, 6);
        int DungeonY = rnd.Next(1, 6);

        int atk1 = 2;
        int atk2 = 3;
        int atk3 = 5;

        goblin goblin1 = new goblin();
        goblin goblin2 = new goblin();
        goblin goblin3 = new goblin();

        goblin1.x = 1;
        goblin1.y = 2;
        goblin2.x = 4;
        goblin2.y = 4;
        goblin3.x = 5;
        goblin3.y = 1;

        orc orc1 = new orc();
        orc orc2 = new orc();

        orc1.x = 3;
        orc1.y = 2;
        orc1.x = 2;
        orc1.y = 4;

        banshee banshee1 = new banshee();
        banshee banshee2 = new banshee();

        banshee1.x = 5;
        banshee1.y = 3;
        banshee2.x = 3;
        banshee2.y = 5;

        Game.startGame();

        bool win = false;

        while(win = false && myWizert.isAlive() != false && myWizert.x != DungeonX && myWizert.y != DungeonY)
        {
           if(myWizert.x != DungeonX && myWizert.y != DungeonY)
           {
            Console.WriteLine("You see a ray of light off in the distance.");
            Console.WriteLine("Although you're tired from traveling and fighting/avoiding monsters, you desperately run towards the light");
            Console.WriteLine("Your efforts paid off. Congrats, you've made it out the dungeon!");
            win = true;
           }
           if(myWizert.isAlive())
           {
            myWizert.move();
           }
           if(myWizert.x == goblin1.x && myWizert.y == goblin1.y && goblin1.isAlive())
           {
            Console.WriteLine("A goblin appears before you. Shouldn't be much of a problem");
            while(goblin1.isAlive() == true && myWizert.isAlive() == true )
            {
               goblin1.bodySlam(atk1);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  goblin1.hp = goblin1.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("No sweat. You defeated the goblin");
           }
           if(myWizert.x == goblin2.x && myWizert.y == goblin2.y && goblin2.isAlive())
           {
            Console.WriteLine("A goblin appears before you. Shouldn't be much of a problem");
            while(goblin1.isAlive() == true && myWizert.isAlive() == true )
            {
               goblin1.bodySlam(atk1);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  goblin2.hp = goblin2.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("No sweat. You defeated the goblin");
           }
           if(myWizert.x == goblin3.x && myWizert.y == goblin3.y && goblin3.isAlive())
           {
            Console.WriteLine("A goblin appears before you. Shouldn't be much of a problem");
            while(goblin1.isAlive() == true && myWizert.isAlive() == true )
            {
               goblin1.bodySlam(atk1);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  goblin3.hp = goblin3.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("No sweat. You defeated the goblin");
           }
           if(myWizert.x == orc1.x && myWizert.y == orc1.y && orc1.isAlive())
           {
            Console.WriteLine("Those footsteps are loud and that smell is atrocious.. An orc stands in front of you.");
            while(orc1.isAlive() == true && myWizert.isAlive() == true )
            {
               orc1.cleave(atk2);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  orc1.hp = orc1.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("The smell is gonna stay with you for a while. You defeated the orc.");
           }
           if(myWizert.x == orc2.x && myWizert.y == orc2.y && orc2.isAlive())
           {
            Console.WriteLine("Those footsteps are loud and that smell is atrocious.. An orc stands in front of you.");
            while(orc2.isAlive() == true && myWizert.isAlive() == true )
            {
               orc2.cleave(atk2);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  orc2.hp = orc2.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("The smell is gonna stay with you for a while. You defeated the orc.");
           }
           if(myWizert.x == banshee1.x && myWizert.y == banshee1.y && banshee2.isAlive())
           {
            Console.WriteLine("You hear a defeaning screech...If only you weren't so unlucky... a banshee appears before you.");
            while(banshee1.isAlive() == true && myWizert.isAlive() == true )
            {
               banshee1.screech(atk3);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  banshee1.hp = banshee1.hp - 5;
                  
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("Lucky you! Your eardrums are still there. You defeated the banshee!");
           }
           if(myWizert.x == banshee2.x && myWizert.y == banshee2.y && banshee2.isAlive())
           {
            Console.WriteLine("You hear a defeaning screech...If only you weren't so unlucky... a banshee appears before you.");
            while(banshee1.isAlive() == true && myWizert.isAlive() == true )
            {
               banshee1.screech(atk3);
               Console.WriteLine("what will you do?");
               Console.WriteLine("Enter 1. attack, 2. heal 3. flee");

               string decision = Console.ReadLine();
               int decide;

               while(!int.TryParse(decision, out decide) && decide > 3 && decide < 1)
               {
                  Console.WriteLine("invalid input. Enter 1. attack, 2. heal 3. flee");
                  decision = Console.ReadLine();
               }
               if(decide == 1)
               {
                  myWizert.fireball();
                  banshee2.hp = banshee2.hp - 5;
               }
               if(decide == 2)
               {
                  myWizert.Heal();
               }
               if(decide == 3)
               {
                  myWizert.flee();
               }
            }
            Console.WriteLine("Lucky you! Your eardrums are still there. You defeated the banshee!");
           }
        }
   }

}