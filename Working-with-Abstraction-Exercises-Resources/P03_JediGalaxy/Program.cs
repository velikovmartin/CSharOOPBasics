using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int dimentionOne = dimestions[0];
            int dimentionTwo = dimestions[1];

            Board board = new Board(dimentionOne, dimentionTwo);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] playerCoordinate = ReadIvosCoordinates(command);
                int[] evilCoordinates = ReadEvilCoordinates();

                Player evil = new Player
                {
                    DimOne = evilCoordinates[0],
                    DimTwo = evilCoordinates[1]
                };

                while (evil.DimOne >= 0 && evil.DimTwo >= 0)
                {
                    if (board.IsInside(evil.DimOne, evil.DimTwo))
                    {
                        board.Matrix[evil.DimOne, evil.DimTwo] = 0;
                    }
                    evil.DimOne--;
                    evil.DimTwo--;
                }

                Player player = new Player
                {
                    DimOne = playerCoordinate[0],
                    DimTwo = playerCoordinate[1]
                };

                while (player.DimOne >= 0 && player.DimTwo < board.Matrix.GetLength(1))
                {
                    if (board.IsInside(player.DimOne, player.DimTwo))
                    {
                        sum += board.Matrix[player.DimOne, player.DimTwo];
                    }

                    player.DimTwo++;
                    player.DimOne--;
                }

                command = Console.ReadLine();
            }

            Print(sum);

        }

        private static int[] ReadEvilCoordinates()
        {
            return Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        private static int[] ReadIvosCoordinates(string command)
        {
            return command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        private static void Print(long sum)
        {
            Console.WriteLine(sum);
        }
    }
}
