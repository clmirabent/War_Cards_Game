using System;
using System.Collections.Generic;

namespace clases.Properties
{
    public class Player
    {
        //atributes 
        public string Nombre { get; set; }
        private List<Carta> _mazo { get; set; } // player's cards in hand
        
        // Constructor
        public Player(string nombre)
        {
            Nombre = nombre;
            _mazo = new List<Carta>(); // Initialize an empty hand
        }
        
        //methods
        
        public void RecibeCartas(Carta carta)
        {
            _mazo.Add(carta);
        }
        
        public void MuestraMano()
        {
            Console.WriteLine($"{Nombre}'s Hand:");
            foreach (var card in _mazo)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
        }

        public Carta JuegaCarta() //Todos los jugadores sacan la primera carta de su paquete.
        {
            Carta primeraCarta = _mazo[0];
            _mazo.RemoveAt(0);
            return primeraCarta;
        }
        
        public bool TieneCartas()
        {
            if (_mazo.Count > 0)
                return true;
        }
        
    }
}