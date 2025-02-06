using System;
using System.Collections.Generic;
using System.Linq;

namespace clases.Properties
{
    public class GameMaster
    {
        //atributes

        private List<Player> _players;
        private Baraja _mazoParaJugar;
        private Dictionary<Player, Carta> cartasPorJugador = new Dictionary<Player, Carta>();
        List<Player> judadoresEmpatados = new List<Player>();

        private int _cartasPorJugador;
        private int _numeroDeTurno;

        //contstructor
        public GameMaster(List<string> playerNames)
        {
            _players = new List<Player>();

            // Crear jugadores y asignarles un nombre
            foreach (var name in playerNames)
            {
                _players.Add(new Player(name));
            }

            _mazoParaJugar = Baraja.CrearBarajasEspanolas();
            _mazoParaJugar.Barajar();

            _cartasPorJugador = Math.Max(1, _mazoParaJugar.CantidadDeCartas / _players.Count); // Cartas que recibe cada jugador
            _numeroDeTurno = _cartasPorJugador;
        }

        public void RepartirCartas()
        {
            int totalDeJugadores = _players.Count; // Número de jugadores

            int totalDeCartas = _mazoParaJugar.CantidadDeCartas; //numero total de cartas en el mazo

            if (totalDeJugadores == 0)
            {
                Console.WriteLine("No hay jugadores en la partida.");
                return;
            }
            
            if (totalDeJugadores > totalDeCartas)
            {
                Console.WriteLine("Error: Hay más jugadores que cartas en el mazo. No se puede repartir.");
                return;
            }
            

            int cartasARepartir = _cartasPorJugador * totalDeJugadores; // Total de cartas que se repartirán

            Console.WriteLine($"Repartiendo {_cartasPorJugador} cartas a cada jugador...");

            // Repartir las cartas a los jugadores
            foreach (var player in _players)
            {
                if (_mazoParaJugar.CantidadDeCartas >= _cartasPorJugador)
                {
                    List<Carta> cartaRecibidas = _mazoParaJugar.RobarCartas(_cartasPorJugador);
                    player.RecibeCartas(cartaRecibidas);
                }
                else
                    Console.WriteLine($"Error: No hay suficientes cartas para repartir a {player.Nombre}.");
            }

            // Descarta las cartas sobrantes
            int cartasApartadas = totalDeCartas - cartasARepartir;
            if (cartasApartadas > 0)
            {
                _mazoParaJugar.RobarCartas(cartasApartadas);
                Console.WriteLine($"Se han descartado {cartasApartadas} cartas.");
            }
        }
        

        public void JugarPartida()
        {
            Console.WriteLine("Empezó el juego");
            int numeroDeRondaActual = 0;
            do
            {
                Console.WriteLine("El numero de Ronda Actual es: " + (numeroDeRondaActual + 1));
                JugarRonda();
                if (judadoresEmpatados.Count > 0)
                {
                    JugarRonda();
                }
                numeroDeRondaActual++;
            } while (numeroDeRondaActual < _numeroDeTurno);
        }

        private Player JugarRonda() //esto devuelve el ganador de la ronda
        {
            List<Carta> CartasJugadas = new List<Carta>();

            foreach (var player in _players)
            {
                player.MuestraMano(); // Muestra su mano
                Carta cartaJugada = player.JuegaCarta(); // el jugador juega su carta

                CartasJugadas.Add(cartaJugada); // se añade la carta a la lista
                cartasPorJugador[player] = cartaJugada;

                Console.WriteLine($"{player.Nombre} juega {cartaJugada}");
            }

            // Ordena las cartas de mayor a menor.
            // Coge la primera (la más alta).
            // Devuelve el jugador que jugó esa carta.
            Player ganador = cartasPorJugador.OrderByDescending(element => (int)element.Value.Valor).First().Key;
            Console.WriteLine($"El ganador de la ronda es: {ganador.Nombre}");

            ganador.RecibeCartas(CartasJugadas);

            return ganador;
        }

        private void Empate()
        {
            HashSet<Carta> seenCartas = new HashSet<Carta>();
            bool empateDetectado = false;
            foreach (var pair in cartasPorJugador)
            {
                if (seenCartas.Contains(pair.Value))
                {
                    Console.WriteLine("Hay un empate!");
                    judadoresEmpatados.Add(pair.Key);
                    empateDetectado = true;
                }
                else
                {
                    seenCartas.Add(pair.Value);
                }
            }

            if (!empateDetectado)
            {
                Console.WriteLine("No hay empate.");
            }
        }
    }
}