﻿using OOP2.DataBase.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Term
{
    public class PlayerStats : ICommand
    {
        private readonly IGameService gameService;

        public PlayerStats(IGameService gameService)
        {
            this.gameService = gameService;
        }

        public void Execute()
        {
            Console.Write("Enter the name of the player: ");
            string playerName = Console.ReadLine();

            var player = gameService.GetGameAccountByName(playerName);

            if (player != null)
            {
                gameService.PrintGames(player);
            }
            else
            {
                Console.WriteLine($"Player {playerName} not found.");
            }
        }
    }
}
