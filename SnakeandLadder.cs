using System;

namespace SnakeLadder
{
    public class Player1
    {
        static void Main(string[] args)
        {
            // one player starting on square one
            int[] players = {1};
            while (true)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    int ns = Turn(i + 1, players[i]);
                    if (ns == 100)
                    {
                        Console.WriteLine("Player {0} wins!", i + 1);
                        return;
                    }
                    players[i] = ns;
                    Console.WriteLine();
                }
            }
        }
    }
}