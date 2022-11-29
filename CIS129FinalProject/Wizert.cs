using System;

namespace wizert;

public static class Wizert 
{
    public static int hp = 100;
    public static int mp = 200;

    

   public static userMove()
   {
       Console.WriteLine("Which direction would you like to move?");
       Console.WriteLine("Enter a number: 1.North 2.South 3.East 4.West");
       var move1 = Console.ReadLine();

       int move2;
       while(!int.TryParse(move1, out move2)) 
       {
           Console.WriteLine("This is not a number.");
           move1 = Console.ReadLine();
       }
       while(move2 != null)
       {
           if(move2 == 1)
           {
               
           }
           else if(move2 == 2)
           {

           }
           else if(move2 == 3)
           {

           }
           else if(move2 == 4)
           {

           }
           else
           {
               Console.WriteLine("Make sure you're number is a number between 1-4");
           }
       }
   }
}