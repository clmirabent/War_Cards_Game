using System;
using System.Collections.Generic;
using clases.Properties;

namespace clases
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            List<string> playerNames = new List<string> { "Alice", "Bob", "Charlie", "David" };

            GameMaster game = new GameMaster(playerNames);
            game.RepartirCartas();  // Reparte cartas a los jugadores
            
            
            
            game.JugarPartida();
            
        }
        }
    }
    