using System;
using System.Collections.Generic;

namespace clases.Properties
{
    public class Player
    {
        //atributes 
        public string Nombre { get; set; }
        private List<Carta> _mano { get; set; } // player's cards in hand
        private int _puntos;
        
        // Constructor
        public Player(string nombre)
        {
            Nombre = nombre;
            _mano = new List<Carta>(); // Initialize an empty hand
            _puntos = 0;
        }
        
        //methods
        
        public void RecibeCarta(Carta carta)
        {
            _mano.Add(carta);
        }

        public void RecibeCartas(List<Carta> cartas)
        {
            _mano.AddRange(cartas);
        }
        
        public void MuestraMano()
        {
            Console.WriteLine($"{Nombre}'s Hand:");
            foreach (var card in _mano)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
        }

        public Carta JuegaCarta() //cada jugador saca la primera carta de su mano.
        {
            Carta primeraCarta = _mano[0];
            _mano.RemoveAt(0);
            return primeraCarta;
        }
        public bool TieneCartas()
        {
            return _mano.Count > 0;
            
        }

        public void SumarPunto()
        {
            _puntos++;
        }
    }
}