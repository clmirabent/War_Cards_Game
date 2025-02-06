using System;
using System.Collections.Generic;
using clases.Properties;

namespace clases
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            List<string> playerNames = new List<string>();
            Console.WriteLine("Name for player 1: ");
            playerNames.Add(Console.ReadLine());
            Console.WriteLine("Name for player 2: ");
            playerNames.Add(Console.ReadLine());

            GameMaster game = new GameMaster(playerNames);
            game.RepartirCartas();  // Reparte cartas a los jugadores
            Console.WriteLine("----------------------------------");
            game.JugarPartida();
            
        }
        }
    }
    