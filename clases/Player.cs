using System.Collections.Generic;

namespace clases.Properties
{
    public class Player
    {
        //atributes 
        public string Nombre { get; set; }
        private List<Carta> _mazo { get; set; } // player's cards in hand
        
        public Player()
        {
            Nombre = new string();
        }
        
        
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
        
    }
}