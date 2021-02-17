using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    class GamesManager : IGamesService
    {
        List<string> _game;
        public GamesManager()
        {
            _game = new List<string>();
        }

        public void Add(Games games)
        {
            _game.Add(games.GameName);
            Console.WriteLine(games.GameName + " Oyunu Eklendi");
        }
    }
}
