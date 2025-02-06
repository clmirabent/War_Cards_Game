using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace clases
{
    public class Baraja
    {
        //atributos
        private List<Carta> _cartas;

        //
        public List<Carta> MazoCartas
        {
            get => _cartas;
        }

        public int CantidadDeCartas
        {
            get => _cartas.Count;
        }

        public Baraja()
        {
            _cartas = new List<Carta>();
        }
        
        //constructor 
        public Baraja(List<Carta> cartas)
        {
            _cartas = cartas;
        }

        public void AgregarCarta(Carta carta)
        {
            _cartas.Add(carta);
        }

        //
        public void Mostrar()
        {
            for (int i = 0; i < _cartas.Count; i++)
            {
                var cartasObtenidas = _cartas[i].ToString();
                Console.WriteLine(cartasObtenidas);
            }
        }

        public static Baraja CrearBarajasEspanolas()
        {
            Baraja objetoBaraja = new Baraja();
            
            foreach (EFigura figura in Enum.GetValues(typeof(EFigura)))
            {
                foreach (EValorCarta valor in Enum.GetValues(typeof(EValorCarta)))
                {
                    Carta objetoCarta = new Carta(figura, valor);
                    objetoBaraja.AgregarCarta(objetoCarta);
                }
            }
            return objetoBaraja;
        }

       
        public void Barajar()
        {
            Random rnd = new Random(); //para generar un orden random 
            int n = _cartas.Count; // numero total de cartas en el mazo
            
            //For each unshuffled item in the collection
            for (int i = n - 1; i > 0; i--) 
            {
                int j = rnd.Next(0, i); //Randomly pick an item which has not been shuffled
                
                // Intercambiar MazoCartas[i] con MazoCartas[j]
                (_cartas[i], _cartas[j]) = (_cartas[j], _cartas[i]);
            }
        }

        public Carta RobarCarta()
        {
            int indiceUltimaCarta = _cartas.Count - 1;
            Carta ultimaCarta = _cartas[indiceUltimaCarta];
            _cartas.RemoveAt(indiceUltimaCarta);
            return ultimaCarta;
        }

        public List<Carta> RobarCartas(int n)
        {
            List<Carta> cartasRobadas = new List<Carta>();
            do
            {
                var cartaRobada = RobarCarta(); //Recieve the robbed card
                cartasRobadas.Add(cartaRobada); // added it to the list

                n--;
                
            } while (n > 0);
            
            return cartasRobadas;

        }
    }
}