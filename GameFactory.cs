using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameFactory
    {
        List<Game> gameList = new List<Game>();

        public void CreateGameList()
        {
            Game gamey;
            gamey = new Game("Celtics", "Rockets", 78, 90);
            gameList.Add(gamey);

            gamey = new Game("Red Sox", "Yankees", 5, 9);
            gameList.Add(gamey);

            gamey = new Game("Patriots", "Seahawks", 21, 28);
            gameList.Add(gamey);

            gamey = new Game("Dolphins", "Raiders", 49, 0);
            gameList.Add(gamey);

            gamey = new Game("Hurricanes", "Panthers", 36, 70);
            gameList.Add(gamey);

            gamey = new Game("Jaguars", "Vikings", 14, 9);
            gameList.Add(gamey);
        }
    }
}
