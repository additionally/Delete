﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer.Read
{
    public class ReadGame
    {
        private GroupProjectEntities context;

        public ReadGame()
        {
            context = new GroupProjectEntities();
        }

        public ReadGame(GroupProjectEntities groupprojectEntities)
        {
            context = groupprojectEntities;
        }

        public List<Game> ReadAllGames()
        {

            List<Game> _games = context.Games.ToList<Game>();
            return _games;
        }

        public Game ReadSpecificGame(int id)
        {
            Game noGameFound = new Game()
            {
                name = "Game Does Not Exist"
            };

            if ((context.Games.SingleOrDefault(x => x.game_id == id)) != null)
            {
                Game _game = context.Games.Where<Game>(x => x.game_id == id).First();
                return _game;
            }
            else { return noGameFound; }

        }

        public decimal ReadGamePayout(string gamename)
        {
            using (var context = new GroupProjectEntities())
            {
                decimal gamepayout = 0;

                var gamepayoutquery = (from e in context.Games
                                       where e.name == gamename
                                       select e.payout);
                foreach (var game in gamepayoutquery)
                {
                    gamepayout = Convert.ToDecimal(game);
                }

                if (gamepayout == 0)
                {
                    return 0;
                }
                else
                {
                    return gamepayout;
                }
            }
        }
    }
}
