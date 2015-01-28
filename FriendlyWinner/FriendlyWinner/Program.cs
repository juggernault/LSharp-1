﻿using System;
using LeagueSharp.Common;

namespace FriendlyWinner
{
    public class Program
    {
        private static void RemoveEventHandler(EventArgs args)
        {
            LeagueSharp.Game.OnGameStart -= Game.Game_OnGameStart;
            LeagueSharp.Game.OnGameUpdate -= Game.Game_Update;
        }

        private static void Main(string[] args)
        {
            LeagueSharp.Game.OnGameStart += Game.Game_OnGameStart;
            LeagueSharp.Game.OnGameUpdate += Game.Game_Update;
            CustomEvents.Game.OnGameEnd += RemoveEventHandler;
        }
    }
}