using System;
using System.Security.Cryptography;

namespace _3_Itransition
{
    class Program
    {
        static private bool Started = true;
        static void Main(string[] args)
        {
            InputChecker.CheckInput(args);
            Table rulesTable = new Table();
            GameLogic newGame = new GameLogic(args);
            var key = HMAC.GenerateKey();
            var computerMove = RandomNumberGenerator.GetInt32(args.Length);
            var hmac = HMAC.GenerateHMAC(key, args[computerMove]);
            Console.WriteLine($"\tHMAC: {hmac} \n\tAvailable Moves:");
            int playerMove = 1;
            while(Started)
            {     
                for (int i = 0; i < args.Length; i++)
                    Console.WriteLine($"\t{i + 1} - {args[i]}");
                Console.WriteLine("\t0 - Exit");
                Console.WriteLine("\t123 - Help");
                Console.Write("\tEnter your move: ");
                playerMove = int.Parse(Console.ReadLine());
                switch (playerMove)
                {
                    case 0:
                        return;
                    case 123:
                        rulesTable.Print(args, newGame.gameobjectRelations);
                        break;
                    default:
                        if (playerMove > 0 && playerMove <= args.Length)
                        {
                            Console.WriteLine("\tYour Move: " + args[playerMove - 1]);
                            Started = !Started;
                        }
                        else Console.WriteLine("\tNot correct input");
                        break;
                }
            }
            Console.WriteLine($"\tPC Move: {args[computerMove]} \n" +
                $"\tResult of game : {newGame.gameobjectRelations[args[playerMove-1] + args[computerMove]]} \n" +
                $"\tKey: {key}");
            Console.ReadLine();
        }
    }
}
