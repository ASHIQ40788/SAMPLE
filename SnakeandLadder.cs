// C# program to find minimum
// number of dice throws required
// to reach last cell from first
// cell of a given snake and ladder board
using System;
using System.Collections.Generic;

public class SnakesLadder
{
    /public class Snakes_and_Ladders
    {// start class
        //Main Method
        public static void main(String[] args) throws IOException
        {// start main method

            //Welcoming Screen
            Console.WriteLine ("\t\t\t\t\t\tWelcome To Snakes And Ladders\n\n");
            while (counter > 0)
            {
            if (counter%10 == 0 && counter != 100)
            {
            if(iteration==-1)
            {
             // subtract 9 from the counter
                    // and sets it to start adding by one
                    counter-=9;
                    iteration=1;
            }
                else
                {
                    System.out.print(counter+"\t");
                     counter-=10;
                    iteration=-1; // set the counter to start subtract by ones
                 }
                if (counter != 0)
                    { 
                   System.out.print("\n" + counter + "\t");
                 System.out.print(counter + "\t"); // just prints out the counter
                counter += iteration; // sets counter to add by iteration
                  }// end while
              }
            }
       }
 }
