﻿using System;
using LeagueSharp.Common;

namespace Surrender
{
    internal class Program
    {
        private static void RemoveEventHandler(EventArgs args)
        {
            LeagueSharp.Game.OnGameStart -= Game.Game_OnGameStart;
            LeagueSharp.Game.OnGameNotifyEvent -= Game.Game_OnGameNotifyEvent;
            LeagueSharp.Game.OnGameUpdate -= Game.Game_OnGameUpdate;

        }

        private static void Main(string[] args)
        {
            UserInterface.CreateMenu();
            RegisterEvents();
        }

        private static void RegisterEvents()
        {
            LeagueSharp.Game.OnGameStart += Game.Game_OnGameStart;
            LeagueSharp.Game.OnGameUpdate += Game.Game_OnGameUpdate;
            LeagueSharp.Game.OnGameNotifyEvent += Game.Game_OnGameNotifyEvent;

            CustomEvents.Game.OnGameEnd += RemoveEventHandler;
        }
    }
}