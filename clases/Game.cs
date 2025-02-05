using System;
using System.Collections.Generic;

namespace clases.Properties
{
    public class GameMaster
    {
        //atributes

        private List<Player> _players;
        private Baraja _cartas;

        //contstructor
        public GameMaster(List<string> playerNames)
        {
            _players = new List<Player>();
            _cartas = new Baraja(); //start game with empty hand
            _cartas.Barajar(); // Mezclar el mazo antes de empezar

            // Crear jugadores y asignarles un nombre
            foreach (var name in playerNames)
            {
                _players.Add(new Player(name));
            }
        }

        public void RepartirCartas()
        {
            Baraja _cartas = Baraja.CrearBarajasEspanolas();
            int numPlayers = _players.Count; // Número de jugadores

            int totalCards = _cartas.MazoCartas.Count; //numero total del mazo

            if (numPlayers == 0)
            {
                Console.WriteLine("No hay jugadores en la partida.");
                return;
            }

            int cardsPerPlayer = totalCards / numPlayers; // Cartas que recibe cada jugador
            int cardsToDeal = cardsPerPlayer * numPlayers; // Total de cartas que se repartirán

            Console.WriteLine($"Repartiendo {cardsPerPlayer} cartas a cada jugador...");

            // Repartir las cartas a los jugadores
            foreach (var player in _players)
            {
                for (int i = 0; i < cardsPerPlayer; i++)
                {
                    Carta drawnCard = _cartas.RobarCarta();
                    player.RecibeCartas(drawnCard);
                }
            }

            // Descarta las cartas sobrantes
            int discardedCards = totalCards - cardsToDeal;
            for (int i = 0; i < discardedCards; i++)
            {
                _cartas.RobarCarta(); //  robamos y no asignamos
            }

            Console.WriteLine($"Se han descartado {discardedCards} cartas.");
        }

        // Mostrar todas las manos de los jugadores
  

        public void TurnoPartida()
        {
            
        }
    }
}



// Método para iniciar el juego
       


    