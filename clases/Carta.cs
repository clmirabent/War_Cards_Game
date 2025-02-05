using System;

namespace clases
{
    public enum EFigura
    {
        Basto,
        Oro,
        Copa,
        Espadas
    }

    public enum EValorCarta
    {
        As = 1,
        Dos = 2,
        Tres = 3,
        Cuatro = 4,
        Cinco = 5,
        Seis = 6,
        Siete = 7,
        Ocho = 8,
        Nueve = 9,
        Diez = 10,
        Jota = 11,
        Reina = 12,
        Rey = 13
    }

    public class Carta
    {
        private EFigura _figura;
        public EFigura Figura
        {
            get { return _figura;}
        }

        public EValorCarta Valor { get; private set; }

        // Constructor
        public Carta(EFigura figura, EValorCarta valor)
        {
            this._figura = figura;
            this.Valor = valor;
        }
        

        public override string ToString()
        {
            return this.ObtenerValor() + " de " + this.ObtenerFigura();
        }

        private string ObtenerFigura()
        {
            switch (_figura)
            {
                case EFigura.Basto:
                    return "Basto";
                case EFigura.Oro:
                    return "Oro";
                case EFigura.Copa:
                    return "Copa";
                case EFigura.Espadas:
                    return "Espadas";
                default:
                    return "";
            }
        }

        private string ObtenerValor()
        {
            switch (Valor)
            {
                case EValorCarta.As:
                    return "As";
                case EValorCarta.Dos:
                    return "Dos";
                case EValorCarta.Tres:
                    return "Tres";
                case EValorCarta.Cuatro:
                    return "Cuatro";
                case EValorCarta.Cinco:
                    return "Cinco";
                case EValorCarta.Seis:
                    return "Seis";
                case EValorCarta.Siete:
                    return "Siete";
                case EValorCarta.Ocho:
                    return "Ocho";
                case EValorCarta.Nueve:
                    return "Nueve";
                case EValorCarta.Diez:
                    return "Diez";
                case EValorCarta.Jota:
                    return "Jota";
                case EValorCarta.Reina:
                    return "Reina";
                case EValorCarta.Rey:
                    return "Rey";
                default:
                    return "";
            }
        }
    }
}
    
    
