using System.Collections.Generic;

namespace clases.Properties
{
    public class GameMaster
    {
        //atributes
        private Player _player;
        private int TurnCount; //Number of turns elapsed

        //contstructor
        public GameMaster(string player1name, string player2name)
        {
            _player = new Player(player1name);
            _player = new Player(player2name);



        }
    }

    
}

    