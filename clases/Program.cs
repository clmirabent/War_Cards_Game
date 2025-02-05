using System;
using System.Collections.Generic;

namespace clases
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool player1 = false;
            
          
          Baraja objetoBaraja = Baraja.CrearBarajasEspanolas();
          objetoBaraja.Mostrar();
          
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