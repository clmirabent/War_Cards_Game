using System;
using System.Collections.Generic;
using clases.Properties;

namespace clases
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          
          Baraja objetoBaraja = Baraja.CrearBarajasEspanolas();
          objetoBaraja.Mostrar();
          
          List<string> playerNames = new List<string> { "Alice", "Bob", "Charlie", "David" };

          GameMaster game = new GameMaster(playerNames);
          game.RepartirCartas();  // Reparte cartas a los jugadores
          
          
          objetoBaraja.Barajar();
          objetoBaraja.Mostrar();
          
          Console.WriteLine("La carta robada es: " + objetoBaraja.RobarCarta());
          Console.WriteLine("Las cartas robadas son:");
          List<Carta> cartasRobadas = objetoBaraja.RobarCartas(2);
          foreach (Carta carta in cartasRobadas)
          {
              Console.WriteLine(carta);
          }
        }
        }
    }
    